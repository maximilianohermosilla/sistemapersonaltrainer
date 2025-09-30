using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sistemapersonaltrainer.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BodyRegions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyRegions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CombinationExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombinationExercises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    IMC = table.Column<decimal>(type: "decimal(65,30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DifficultyLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExerciseArmTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseArmTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExerciseCalifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCalifications", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExerciseModes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseModes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FootElevations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootElevations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ForceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForceTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Grips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grips", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lateralities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lateralities", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LoadPositionEnds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadPositionEnds", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mechanics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechanics", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MuscleGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Muscles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muscles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Patterns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patterns", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlaneOfMotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaneOfMotions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Postures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postures", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrlShortVideo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UrlLongVideo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DifficultyLevelId = table.Column<int>(type: "int", nullable: true),
                    MuscleGroupId = table.Column<int>(type: "int", nullable: true),
                    PrimeMoverMuscleId = table.Column<int>(type: "int", nullable: true),
                    SecondaryMoverMuscleId = table.Column<int>(type: "int", nullable: true),
                    TertiaryMoverMuscleId = table.Column<int>(type: "int", nullable: true),
                    PrimaryEquipmentId = table.Column<int>(type: "int", nullable: true),
                    PrimaryItems = table.Column<int>(type: "int", nullable: true),
                    SecondaryEquipmentId = table.Column<int>(type: "int", nullable: true),
                    SecondaryItems = table.Column<int>(type: "int", nullable: true),
                    PostureId = table.Column<int>(type: "int", nullable: true),
                    ExerciseArmTypeId = table.Column<int>(type: "int", nullable: true),
                    ExerciseArmModeId = table.Column<int>(type: "int", nullable: true),
                    GripId = table.Column<int>(type: "int", nullable: true),
                    LoadPositionEndId = table.Column<int>(type: "int", nullable: true),
                    ExerciseLegModeId = table.Column<int>(type: "int", nullable: true),
                    FootElevationId = table.Column<int>(type: "int", nullable: true),
                    CombinationExerciseId = table.Column<int>(type: "int", nullable: true),
                    PrimaryPatternId = table.Column<int>(type: "int", nullable: true),
                    SecondaryPatternId = table.Column<int>(type: "int", nullable: true),
                    TertiaryPatternId = table.Column<int>(type: "int", nullable: true),
                    PrimaryPlaneOfMotionId = table.Column<int>(type: "int", nullable: true),
                    SecondaryPlaneOfMotionId = table.Column<int>(type: "int", nullable: true),
                    TertiaryPlaneOfMotionId = table.Column<int>(type: "int", nullable: true),
                    BodyRegionId = table.Column<int>(type: "int", nullable: true),
                    ForceTypeId = table.Column<int>(type: "int", nullable: true),
                    MechanicId = table.Column<int>(type: "int", nullable: true),
                    LateralityId = table.Column<int>(type: "int", nullable: true),
                    ExerciseClassificationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_BodyRegions_BodyRegionId",
                        column: x => x.BodyRegionId,
                        principalTable: "BodyRegions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_CombinationExercises_CombinationExerciseId",
                        column: x => x.CombinationExerciseId,
                        principalTable: "CombinationExercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_DifficultyLevels_DifficultyLevelId",
                        column: x => x.DifficultyLevelId,
                        principalTable: "DifficultyLevels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Equipments_PrimaryEquipmentId",
                        column: x => x.PrimaryEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Equipments_SecondaryEquipmentId",
                        column: x => x.SecondaryEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseArmTypes_ExerciseArmTypeId",
                        column: x => x.ExerciseArmTypeId,
                        principalTable: "ExerciseArmTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseCalifications_ExerciseClassificationId",
                        column: x => x.ExerciseClassificationId,
                        principalTable: "ExerciseCalifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseModes_ExerciseArmModeId",
                        column: x => x.ExerciseArmModeId,
                        principalTable: "ExerciseModes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_ExerciseModes_ExerciseLegModeId",
                        column: x => x.ExerciseLegModeId,
                        principalTable: "ExerciseModes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_FootElevations_FootElevationId",
                        column: x => x.FootElevationId,
                        principalTable: "FootElevations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_ForceTypes_ForceTypeId",
                        column: x => x.ForceTypeId,
                        principalTable: "ForceTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Grips_GripId",
                        column: x => x.GripId,
                        principalTable: "Grips",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Lateralities_LateralityId",
                        column: x => x.LateralityId,
                        principalTable: "Lateralities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_LoadPositionEnds_LoadPositionEndId",
                        column: x => x.LoadPositionEndId,
                        principalTable: "LoadPositionEnds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Mechanics_MechanicId",
                        column: x => x.MechanicId,
                        principalTable: "Mechanics",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Muscles_PrimeMoverMuscleId",
                        column: x => x.PrimeMoverMuscleId,
                        principalTable: "Muscles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Muscles_SecondaryMoverMuscleId",
                        column: x => x.SecondaryMoverMuscleId,
                        principalTable: "Muscles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Muscles_TertiaryMoverMuscleId",
                        column: x => x.TertiaryMoverMuscleId,
                        principalTable: "Muscles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Patterns_PrimaryPatternId",
                        column: x => x.PrimaryPatternId,
                        principalTable: "Patterns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Patterns_SecondaryPatternId",
                        column: x => x.SecondaryPatternId,
                        principalTable: "Patterns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Patterns_TertiaryPatternId",
                        column: x => x.TertiaryPatternId,
                        principalTable: "Patterns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_PlaneOfMotions_PrimaryPlaneOfMotionId",
                        column: x => x.PrimaryPlaneOfMotionId,
                        principalTable: "PlaneOfMotions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_PlaneOfMotions_SecondaryPlaneOfMotionId",
                        column: x => x.SecondaryPlaneOfMotionId,
                        principalTable: "PlaneOfMotions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_PlaneOfMotions_TertiaryPlaneOfMotionId",
                        column: x => x.TertiaryPlaneOfMotionId,
                        principalTable: "PlaneOfMotions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exercises_Postures_PostureId",
                        column: x => x.PostureId,
                        principalTable: "Postures",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Workouts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkoutActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutActivities_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkoutActivityExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WorkoutActivityId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    Series = table.Column<int>(type: "int", nullable: true),
                    Repetitions = table.Column<int>(type: "int", nullable: true),
                    RestMinutes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutActivityExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutActivityExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkoutActivityExercises_WorkoutActivities_WorkoutActivityId",
                        column: x => x.WorkoutActivityId,
                        principalTable: "WorkoutActivities",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Enabled", "LastName", "Name", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "maximiliano_hermosilla@hotmail.com", true, "Sistemas", "Administrador", "U+QpQHyCKuYC78AAH05KwA==", "admin" },
                    { 2, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "isaias.luque@mayidev.com", true, "Luque", "Isaias", "U+QpQHyCKuYC78AAH05KwA==", "isaiasLuque" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_BodyRegionId",
                table: "Exercises",
                column: "BodyRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_CombinationExerciseId",
                table: "Exercises",
                column: "CombinationExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_DifficultyLevelId",
                table: "Exercises",
                column: "DifficultyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseArmModeId",
                table: "Exercises",
                column: "ExerciseArmModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseArmTypeId",
                table: "Exercises",
                column: "ExerciseArmTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseClassificationId",
                table: "Exercises",
                column: "ExerciseClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseLegModeId",
                table: "Exercises",
                column: "ExerciseLegModeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_FootElevationId",
                table: "Exercises",
                column: "FootElevationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ForceTypeId",
                table: "Exercises",
                column: "ForceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_GripId",
                table: "Exercises",
                column: "GripId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_LateralityId",
                table: "Exercises",
                column: "LateralityId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_LoadPositionEndId",
                table: "Exercises",
                column: "LoadPositionEndId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_MechanicId",
                table: "Exercises",
                column: "MechanicId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_MuscleGroupId",
                table: "Exercises",
                column: "MuscleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_PostureId",
                table: "Exercises",
                column: "PostureId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_PrimaryEquipmentId",
                table: "Exercises",
                column: "PrimaryEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_PrimaryPatternId",
                table: "Exercises",
                column: "PrimaryPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_PrimaryPlaneOfMotionId",
                table: "Exercises",
                column: "PrimaryPlaneOfMotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_PrimeMoverMuscleId",
                table: "Exercises",
                column: "PrimeMoverMuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_SecondaryEquipmentId",
                table: "Exercises",
                column: "SecondaryEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_SecondaryMoverMuscleId",
                table: "Exercises",
                column: "SecondaryMoverMuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_SecondaryPatternId",
                table: "Exercises",
                column: "SecondaryPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_SecondaryPlaneOfMotionId",
                table: "Exercises",
                column: "SecondaryPlaneOfMotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TertiaryMoverMuscleId",
                table: "Exercises",
                column: "TertiaryMoverMuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TertiaryPatternId",
                table: "Exercises",
                column: "TertiaryPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_TertiaryPlaneOfMotionId",
                table: "Exercises",
                column: "TertiaryPlaneOfMotionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutActivities_WorkoutId",
                table: "WorkoutActivities",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutActivityExercises_ExerciseId",
                table: "WorkoutActivityExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutActivityExercises_WorkoutActivityId",
                table: "WorkoutActivityExercises",
                column: "WorkoutActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_CustomerId",
                table: "Workouts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserId",
                table: "Workouts",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "WorkoutActivityExercises");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "WorkoutActivities");

            migrationBuilder.DropTable(
                name: "BodyRegions");

            migrationBuilder.DropTable(
                name: "CombinationExercises");

            migrationBuilder.DropTable(
                name: "DifficultyLevels");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "ExerciseArmTypes");

            migrationBuilder.DropTable(
                name: "ExerciseCalifications");

            migrationBuilder.DropTable(
                name: "ExerciseModes");

            migrationBuilder.DropTable(
                name: "FootElevations");

            migrationBuilder.DropTable(
                name: "ForceTypes");

            migrationBuilder.DropTable(
                name: "Grips");

            migrationBuilder.DropTable(
                name: "Lateralities");

            migrationBuilder.DropTable(
                name: "LoadPositionEnds");

            migrationBuilder.DropTable(
                name: "Mechanics");

            migrationBuilder.DropTable(
                name: "MuscleGroups");

            migrationBuilder.DropTable(
                name: "Muscles");

            migrationBuilder.DropTable(
                name: "Patterns");

            migrationBuilder.DropTable(
                name: "PlaneOfMotions");

            migrationBuilder.DropTable(
                name: "Postures");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
