using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemapersonaltrainer.Server.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutExerciseWeightAndAproximationSeries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeriesAproximation",
                table: "WorkoutActivityExercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "WorkoutActivityExercises",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeriesAproximation",
                table: "WorkoutActivityExercises");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "WorkoutActivityExercises");
        }
    }
}
