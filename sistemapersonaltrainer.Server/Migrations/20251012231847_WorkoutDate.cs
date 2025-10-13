using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistemapersonaltrainer.Server.Migrations
{
    /// <inheritdoc />
    public partial class WorkoutDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Workouts",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseId",
                table: "WorkoutActivityExercises",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Aductor Mayor");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Deltoides Anterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Bíceps Braquial");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Bíceps Femoral");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Braquial");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Braquiorradial");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Erector de la Columna");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Extensor Largo del Dedo Gordo");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Flexor Radial del Carpo");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Gastrocnemio");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Glúteo Mayor");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Glúteo Medio");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Glúteo Menor");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Psoas Iliaco");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Dorsal Ancho");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Oblicuos");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Pectoral Mayor");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Deltoides Posterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Cuádriceps Femoral");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Recto Abdominal");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "Recto Femoral");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "Romboides");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "Serrato Anterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "Sóleo");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "Tensor de la Fascia Lata");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "Redondo Mayor");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "Redondo Menor");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "Tibial Anterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Tibial Posterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "Transverso del Abdomen");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "Trapecio");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Tríceps Braquial");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "Trapecio Superior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Deltoides Lateral");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Ancóneo");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "Infraespinoso");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Elevador de la Escápula");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Extensor Largo de los Dedos");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Supraespinoso");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "Deltoides Medial");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Subescapular");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Vasto Medial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Workouts");

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseId",
                table: "WorkoutActivityExercises",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Adductor Magnus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Anterior Deltoids");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Biceps Brachii");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Biceps Femoris");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Brachialis");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Brachioradialis");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Erector Spinae");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Extensor Hallucis Longus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Flexor Carpi Radialis");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Gastrocnemius");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Gluteus Maximus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Gluteus Medius");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Gluteus Minimus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Iliopsoas");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Latissimus Dorsi");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Obliques");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Pectoralis Major");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Posterior Deltoids");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Quadriceps Femoris");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Rectus Abdominis");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "Rectus Femoris");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "Rhomboids");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "Serratus Anterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "Soleus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "Tensor Fasciae Latae");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "Teres Major");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "Teres Minor");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "Tibialis Anterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Tibialis Posterior");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "Transverse Abdominis");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "Trapezius");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Triceps Brachii");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "Upper Trapezius");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Lateral Deltoids");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Anconeus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "Infraspinatus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Levator Scapulae");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Extensor Digitorum Longus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Supraspinatus");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "Medial Deltoids");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Subscapularis");

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Vastus Mediais");
        }
    }
}
