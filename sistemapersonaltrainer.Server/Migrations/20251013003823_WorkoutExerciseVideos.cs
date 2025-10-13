using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemapersonaltrainer.Server.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutExerciseVideos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LongVideo",
                table: "WorkoutActivityExercises",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ShortVideo",
                table: "WorkoutActivityExercises",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongVideo",
                table: "WorkoutActivityExercises");

            migrationBuilder.DropColumn(
                name: "ShortVideo",
                table: "WorkoutActivityExercises");
        }
    }
}
