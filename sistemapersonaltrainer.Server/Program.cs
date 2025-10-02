using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using sistemapersonaltrainer.Server.Data;
using sistemapersonaltrainer.Server.Data.Interfaces;
using sistemapersonaltrainer.Server.Data.Repositories;
using sistemapersonaltrainer.Server.Helpers;
using sistemapersonaltrainer.Server.Profiles;
using sistemapersonaltrainer.Server.Responses.Interfaces;
using sistemapersonaltrainer.Server.Responses.Services;
using System.Text;


#region builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySQLConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySQLConnection"))));

// Configurar Response Error Parametros
builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var errors = context.ModelState.Values
            .SelectMany(v => v.Errors)
            .Select(e => e.ErrorMessage)
            .ToList();

        var customErrorResponse = new
        {
            Message = string.Join(' ', errors),
            //Status = StatusCodes.Status400BadRequest,
            //Title = "Validation Error",
            //Errors = errors,
            //Timestamp = DateTime.UtcNow
        };
        return new BadRequestObjectResult(customErrorResponse);
    };
});

// Configurar AutoMapper
builder.Services.AddAutoMapper(config => new MappingProfile(config));

// Configurar interfaces de repositorios y servicios
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IExerciseRepository, ExerciseRepository>();
builder.Services.AddScoped<IExerciseService, ExerciseService>();

//ADD CORS
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
    builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//AUTHENTICATION JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
        };

        options.Events = new JwtBearerEvents
        {
            OnChallenge = async context =>
            {
                context.HandleResponse();
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                context.Response.ContentType = "application/json";

                var response = new
                {
                    Message = "Credenciales inválidas",
                    //ErrorCode = "INVALID_TOKEN_OR_MISSING_AUTH"
                };
                await context.Response.WriteAsJsonAsync(response);
            }
        };
    }
);

builder.Services.AddAuthorization();

builder.Host.UseSerilog((context, services, configuration) => configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext()
        .WriteTo.Console());

#endregion


#region app
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//APP USE CORS
app.UseCors(policy => policy.AllowAnyHeader()
                            .AllowAnyMethod()
                            .SetIsOriginAllowed(origin => true)
                            .AllowCredentials()
);

//app.UseHttpsRedirection();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseMiddleware<CustomUnsupportedMediaTypeMiddleware>();

// Aplicar migraciones automáticamente
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    try
    {
        context.Database.Migrate();
        if (!context!.Exercises!.Any())
        {
            ExercisesHelper exercisesHelper = new ExercisesHelper();
            context!.Exercises!.AddRange(exercisesHelper.exercisesList);
            context!.SaveChanges();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error aplicando migraciones: {ex.Message}");
    }
}

app.MapFallbackToFile("/index.html");

app.Run();
#endregion