using Microsoft.EntityFrameworkCore;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {

            });


            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Administrador",
                    LastName = "Sistemas",
                    Email = "maximiliano_hermosilla@hotmail.com",
                    UserName = "admin",
                    Password = "U+QpQHyCKuYC78AAH05KwA==",
                    CreatedAt = new DateTime(2025, 09, 01, 00, 0, 0, DateTimeKind.Utc),
                    Enabled = true
                },
                new User
                {
                    Id = 2,
                    Name = "Isaias",
                    LastName = "Luque",
                    Email = "isaias.luque@mayidev.com",
                    UserName = "isaiasLuque",
                    Password = "U+QpQHyCKuYC78AAH05KwA==",
                    CreatedAt = new DateTime(2025, 09, 01, 00, 0, 0, DateTimeKind.Utc),
                    Enabled = true
                }
            );
        }
    }
}
