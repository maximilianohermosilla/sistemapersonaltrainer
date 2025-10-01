using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sistemapersonaltrainer.Server.Migrations
{
    /// <inheritdoc />
    public partial class HasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseCalifications_ExerciseClassificationId",
                table: "Exercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseCalifications",
                table: "ExerciseCalifications");

            migrationBuilder.RenameTable(
                name: "ExerciseCalifications",
                newName: "ExerciseClassifications");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseClassifications",
                table: "ExerciseClassifications",
                column: "Id");

            migrationBuilder.InsertData(
                table: "BodyRegions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Centro", "Core" },
                    { 2, "Cuerpo Completo", "Full Body" },
                    { 3, "Cuerpo Inferior", "Lower Body" },
                    { 4, "Cuerpo Superior", "Upper Body" }
                });

            migrationBuilder.InsertData(
                table: "CombinationExercises",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Ejercicio Combinado", "Combo Exercise" },
                    { 2, "Ejercicio Simple", "Single Exercise" }
                });

            migrationBuilder.InsertData(
                table: "DifficultyLevels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Avanzado", "Advanced" },
                    { 2, "Principiante", "Beginner" },
                    { 3, "Experto", "Expert" },
                    { 4, "Gran Maestro", "Grand Master" },
                    { 5, "Intermedio", "Intermediate" },
                    { 6, "Legendario", "Legendary" },
                    { 7, "Maestro", "Master" },
                    { 8, "Novato", "Novice" }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Ab Wheel" },
                    { 2, null, "Barbell" },
                    { 3, null, "Battle Ropes" },
                    { 4, null, "Bench (Decline)" },
                    { 5, null, "Bench (Flat)" },
                    { 6, null, "Bench (Incline)" },
                    { 7, null, "Bodyweight" },
                    { 8, null, "Bulgarian Bag" },
                    { 9, null, "Cable" },
                    { 10, null, "Climbing Rope" },
                    { 11, null, "Clubbell" },
                    { 12, null, "Dumbbell" },
                    { 13, null, "EZ Bar" },
                    { 14, null, "Gravity Boots" },
                    { 15, null, "Gymnastic Rings" },
                    { 16, null, "Heavy Sandbag" },
                    { 17, null, "Indian Club" },
                    { 18, null, "Kettlebell" },
                    { 19, null, "Landmine" },
                    { 20, null, "Macebell" },
                    { 21, null, "Medicine Ball" },
                    { 22, null, "Miniband" },
                    { 23, null, "Parallette Bars" },
                    { 24, null, "Plyo Box" },
                    { 25, null, "Pull Up Bar" },
                    { 26, null, "Resistance Band" },
                    { 27, null, "Sandbag" },
                    { 28, null, "Slam Ball" },
                    { 29, null, "Slant Board" },
                    { 30, null, "Sled" },
                    { 31, null, "Sledge Hammer" },
                    { 32, null, "Sliders" },
                    { 33, null, "Stability Ball" },
                    { 34, null, "Superband" },
                    { 35, null, "Suspension Trainer" },
                    { 36, null, "Tire" },
                    { 37, null, "Trap Bar" },
                    { 38, null, "Wall Ball" },
                    { 39, null, "Weight Plate" },
                    { 40, null, "None" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseArmTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Doble brazo", "Double Arm" },
                    { 2, "Sin brazos", "No Arms" },
                    { 3, "Un brazo", "Single Arm" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseClassifications",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Flujo animal", "Animal Flow" },
                    { 2, "Equilibrio", "Balance" },
                    { 3, "Ejercicios balísticos", "Ballistics" },
                    { 4, "Culturismo", "Bodybuilding" },
                    { 5, "Calistenia", "Calisthenics" },
                    { 6, "Movimientos de fuerza sostenida", "Grinds" },
                    { 7, "Movilidad", "Mobility" },
                    { 8, "Halterofilia", "Olympic Weightlifting" },
                    { 9, "Halterofilia", "Olympic Weightlifting " },
                    { 10, "Pliometría", "Plyometric" },
                    { 11, "Postural", "Postural" },
                    { 12, "Levantamiento de potencia", "Powerlifting" },
                    { 13, "Sin clasificar", "Unsorted*" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseModes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Alternando", "Alternating" },
                    { 2, "Continuo", "Continuous" }
                });

            migrationBuilder.InsertData(
                table: "FootElevations",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Pies Elevados", "Feet Elevated" },
                    { 2, "Pie Elevado", "Foot Elevated" },
                    { 3, "Pie Elevado (Frontal)", "Foot Elevated (Front)" },
                    { 4, "Pie Elevado (Lateral)", "Foot Elevated (Lateral)" },
                    { 5, "Pie Elevado (Trasero)", "Foot Elevated (Rear)" },
                    { 6, "Pie Elevado (De costado)", "Foot Elevated (Side)" },
                    { 7, "Tacones elevados", "Heels Elevated" },
                    { 8, "Sin elevación", "No Elevation" },
                    { 9, "Dedos elevados", "Toes Elevated" }
                });

            migrationBuilder.InsertData(
                table: "ForceTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Otro", "Other" },
                    { 2, "Tirar", "Pull" },
                    { 3, "Empujar", "Push" },
                    { 4, "Empujar y Tirar", "Push & Pull" },
                    { 5, "Sin clasificar*", "Unsorted*" }
                });

            migrationBuilder.InsertData(
                table: "Grips",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Con agarrón hacia arriba", "Bottoms Up" },
                    { 2, "Agarre de cuerno invertido", "Bottoms Up Horn Grip" },
                    { 3, "Agarre de aplastamiento", "Crush Grip" },
                    { 4, "Agarre falso", "False Grip" },
                    { 5, "Agarre con las yemas de los dedos", "Fingertip" },
                    { 6, "Palma plana", "Flat Palm" },
                    { 7, "Agarre con el antebrazo", "Forearm" },
                    { 8, "Agarre de copa", "Goblet" },
                    { 9, "Agarre con asistencia de la mano", "Hand Assisted" },
                    { 10, "Agarre con apoyo en la cabeza", "Head Supported" },
                    { 11, "Agarre de cuerno", "Horn Grip" },
                    { 12, "Agarre mixto", "Mixed Grip" },
                    { 13, "Agarre neutral o de martillo", "Neutral" },
                    { 14, "Sin agarre", "No Grip" },
                    { 15, "Otro", "Other" },
                    { 16, "Agarre pronado (palmas hacia abajo)", "Pronated" },
                    { 17, "Agarre supinado (palmas hacia arriba)", "Supinated" },
                    { 18, "Agarre de camarero", "Waiter Hold" }
                });

            migrationBuilder.InsertData(
                table: "Lateralities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bilateral", "Bilateral" },
                    { 2, "Contralateral", "Contralateral" },
                    { 3, "Ipsolateral", "Ipsilateral" },
                    { 4, "Unilateral", "Unilateral" }
                });

            migrationBuilder.InsertData(
                table: "LoadPositionEnds",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Por encima del pecho", "Above Chest" },
                    { 2, "En rack trasero", "Back Rack" },
                    { 3, "Abrazo de oso", "Bear Hug" },
                    { 4, "A la espalda", "Behind Back" },
                    { 5, "En rack frontal", "Front Rack" },
                    { 6, "En el pliegue de la cadera", "Hip Crease" },
                    { 7, "Lateral", "Lateral" },
                    { 8, "Sostenido bajo", "Low Hold" },
                    { 9, "Sin carga", "No Load" },
                    { 10, "Orden", "Order" },
                    { 11, "Otro", "Other" },
                    { 12, "Por encima de la cabeza", "Overhead" },
                    { 13, "En el hombro", "Shoulder" },
                    { 14, "Como maletín", "Suitcase" },
                    { 15, "Zercher", "Zercher" }
                });

            migrationBuilder.InsertData(
                table: "Mechanics",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Compuesto", "Compound" },
                    { 2, "Aislamiento", "Isolation" },
                    { 3, "Tirar", "Pull" }
                });

            migrationBuilder.InsertData(
                table: "MuscleGroups",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Abdominales", "Abdominals" },
                    { 2, "Aductores", "Adductors" },
                    { 3, "Espalda", "Back" },
                    { 4, "Biceps", "Biceps" },
                    { 5, "Gemelos", "Calves" },
                    { 6, "Pecho", "Chest" },
                    { 7, "Antebrazos", "Forearms" },
                    { 8, "Gluteos", "Glutes" },
                    { 9, "Isquiotibiales", "Hamstrings" },
                    { 10, "Flexores de cadera", "Hip Flexors" },
                    { 11, "Quadriceps", "Quadriceps" },
                    { 12, "Espinillas", "Shins" },
                    { 13, "Hombros", "Shoulders" },
                    { 14, "Trapecios", "Trapezius" },
                    { 15, "Triceps", "Triceps" }
                });

            migrationBuilder.InsertData(
                table: "Muscles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Aductor Mayor", "Adductor Magnus" },
                    { 2, "Deltoides Anterior", "Anterior Deltoids" },
                    { 3, "Bíceps Braquial", "Biceps Brachii" },
                    { 4, "Bíceps Femoral", "Biceps Femoris" },
                    { 5, "Braquial", "Brachialis" },
                    { 6, "Braquiorradial", "Brachioradialis" },
                    { 7, "Erector de la Columna", "Erector Spinae" },
                    { 8, "Extensor Largo del Dedo Gordo", "Extensor Hallucis Longus" },
                    { 9, "Flexor Radial del Carpo", "Flexor Carpi Radialis" },
                    { 10, "Gastrocnemio", "Gastrocnemius" },
                    { 11, "Glúteo Mayor", "Gluteus Maximus" },
                    { 12, "Glúteo Medio", "Gluteus Medius" },
                    { 13, "Glúteo Menor", "Gluteus Minimus" },
                    { 14, "Psoas Iliaco", "Iliopsoas" },
                    { 15, "Dorsal Ancho", "Latissimus Dorsi" },
                    { 16, "Oblicuos", "Obliques" },
                    { 17, "Pectoral Mayor", "Pectoralis Major" },
                    { 18, "Deltoides Posterior", "Posterior Deltoids" },
                    { 19, "Cuádriceps Femoral", "Quadriceps Femoris" },
                    { 20, "Recto Abdominal", "Rectus Abdominis" },
                    { 21, "Recto Femoral", "Rectus Femoris" },
                    { 22, "Romboides", "Rhomboids" },
                    { 23, "Serrato Anterior", "Serratus Anterior" },
                    { 24, "Sóleo", "Soleus" },
                    { 25, "Tensor de la Fascia Lata", "Tensor Fasciae Latae" },
                    { 26, "Redondo Mayor", "Teres Major" },
                    { 27, "Redondo Menor", "Teres Minor" },
                    { 28, "Tibial Anterior", "Tibialis Anterior" },
                    { 29, "Tibial Posterior", "Tibialis Posterior" },
                    { 30, "Transverso del Abdomen", "Transverse Abdominis" },
                    { 31, "Trapecio", "Trapezius" },
                    { 32, "Tríceps Braquial", "Triceps Brachii" },
                    { 33, "Trapecio Superior", "Upper Trapezius" },
                    { 34, "Deltoides Lateral", "Lateral Deltoids" },
                    { 35, "Ancóneo", "Anconeus" },
                    { 36, "Infraespinoso", "Infraspinatus" },
                    { 37, "Elevador de la Escápula", "Levator Scapulae" },
                    { 38, "Extensor Largo de los Dedos", "Extensor Digitorum Longus" },
                    { 39, "Supraespinoso", "Supraspinatus" },
                    { 40, "Deltoides Medial", "Medial Deltoids" },
                    { 41, "Subescapular", "Subscapularis" },
                    { 42, "Vasto Medial", "Vastus Mediais" }
                });

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Dorsiflexión de tobillo", "Ankle Dorsiflexion" },
                    { 2, "Flexión plantar de tobillo", "Ankle Plantar Flexion" },
                    { 3, "Anti-extensión", "Anti-Extension" },
                    { 4, "Anti-flexión", "Anti-Flexion" },
                    { 5, "Anti-flexión lateral", "Anti-Lateral Flexion" },
                    { 6, "Anti-rotación", "Anti-Rotational" },
                    { 7, "Extensión de codo", "Elbow Extension" },
                    { 8, "Flexión de codo", "Elbow Flexion" },
                    { 9, "Abducción de cadera", "Hip Abduction" },
                    { 10, "Aducción de cadera", "Hip Adduction" },
                    { 11, "Dominante de cadera", "Hip Dominant" },
                    { 12, "Extensión de cadera", "Hip Extension" },
                    { 13, "Rotación externa de cadera", "Hip External Rotation" },
                    { 14, "Flexión de cadera", "Hip Flexion" },
                    { 15, "Bisagra de cadera", "Hip Hinge" },
                    { 16, "Aducción horizontal", "Horizontal Adduction" },
                    { 17, "Tracción horizontal", "Horizontal Pull" },
                    { 18, "Empuje horizontal", "Horizontal Push" },
                    { 19, "Sostén isométrico", "Isometric Hold" },
                    { 20, "Dominante de rodilla", "Knee Dominant" },
                    { 21, "Flexión lateral", "Lateral Flexion" },
                    { 22, "Desplazamiento lateral", "Lateral Locomotion" },
                    { 23, "Carga en desplazamiento", "Loaded Carry" },
                    { 24, "Desplazamiento", "Locomotion" },
                    { 25, "Otro", "Other" },
                    { 26, "Rotacional", "Rotational" },
                    { 27, "Elevación escapular", "Scapular Elevation" },
                    { 28, "Abducción de hombro", "Shoulder Abduction" },
                    { 29, "Rotación externa de hombro", "Shoulder External Rotation" },
                    { 30, "Flexión de hombro", "Shoulder Flexion" },
                    { 31, "Rotación interna de hombro", "Shoulder Internal Rotation" },
                    { 32, "Elevación en el plano escapular del hombro", "Shoulder Scapular Plane Elevation" },
                    { 33, "Extensión espinal", "Spinal Extension" },
                    { 34, "Flexión espinal", "Spinal Flexion" },
                    { 35, "Rotación espinal", "Spinal Rotational" },
                    { 36, "Sin clasificar*", "Unsorted*" },
                    { 37, "Tracción vertical", "Vertical Pull" },
                    { 38, "Empuje vertical", "Vertical Push" },
                    { 39, "Extensión de muñeca", "Wrist Extension" },
                    { 40, "Flexión de muñeca", "Wrist Flexion" },
                    { 41, "Rotación interna de cadera", "Hip Internal Rotation" }
                });

            migrationBuilder.InsertData(
                table: "PlaneOfMotions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Plano Frontal", "Frontal Plane" },
                    { 2, "Plano Sagital", "Sagittal Plane" },
                    { 3, "Plano Transversal", "Transverse Plane" }
                });

            migrationBuilder.InsertData(
                table: "Postures",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "90/90 Sentado", "90/90 Seated" },
                    { 2, "Puente", "Bridge" },
                    { 3, "Media rodilla", "Half Kneeling" },
                    { 4, "Colgado", "Hanging" },
                    { 5, "Postura del jinete", "Horse Stance" },
                    { 6, "Invertida", "Inverted" },
                    { 7, "Estocada isométrica", "Isometric Split Squat" },
                    { 8, "Plancha a cuatro patas con rodilla elevada", "Knee Hover Quadruped" },
                    { 9, "Estocada con rodilla sobre el pie", "Knee Over Toe Split Squat" },
                    { 10, "Apoyado de rodillas", "Knee Supported" },
                    { 11, "Arrodillado", "Kneeling" },
                    { 12, "Posición L sentado", "L Sit" },
                    { 13, "Marcha", "March" },
                    { 14, "Otra", "Other" },
                    { 15, "Prono (boca abajo)", "Prone" },
                    { 16, "A cuatro patas", "Quadruped" },
                    { 17, "Carrera", "Running" },
                    { 18, "Sentado", "Seated" },
                    { 19, "Sentado en el suelo", "Seated Floor" },
                    { 20, "Sentado en caja de espinillas", "Shin Box Seated" },
                    { 21, "De lado", "Side Lying" },
                    { 22, "Plancha lateral", "Side Plank" },
                    { 23, "Puente a una pierna", "Single Leg Bridge" },
                    { 24, "De pie a una pierna", "Single Leg Standing" },
                    { 25, "De pie a una pierna con rodilla flexionada", "Single Leg Standing Bent Knee" },
                    { 26, "Apoyado a una pierna", "Single Leg Supported" },
                    { 27, "Estocada", "Split Squat" },
                    { 28, "Postura escalonada", "Staggered Stance" },
                    { 29, "De pie", "Standing" },
                    { 30, "Supino (boca arriba)", "Supine" },
                    { 31, "De rodillas alto", "Tall Kneeling" },
                    { 32, "Equilibrio en la punta del pie", "Toe Balance" },
                    { 33, "Posición L sentado agrupado", "Tuck L Sit" },
                    { 34, "Posición V sentado", "V Sit Seated" },
                    { 35, "Caminando", "Walking" },
                    { 36, "Sentado en la pared", "Wall Sit" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseClassifications_ExerciseClassificationId",
                table: "Exercises",
                column: "ExerciseClassificationId",
                principalTable: "ExerciseClassifications",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseClassifications_ExerciseClassificationId",
                table: "Exercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseClassifications",
                table: "ExerciseClassifications");

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BodyRegions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CombinationExercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CombinationExercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ExerciseArmTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseArmTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseArmTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExerciseClassifications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExerciseModes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseModes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FootElevations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ForceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ForceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ForceTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ForceTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ForceTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Grips",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lateralities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lateralities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lateralities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lateralities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LoadPositionEnds",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mechanics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PlaneOfMotions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaneOfMotions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlaneOfMotions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Postures",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.RenameTable(
                name: "ExerciseClassifications",
                newName: "ExerciseCalifications");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseCalifications",
                table: "ExerciseCalifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseCalifications_ExerciseClassificationId",
                table: "Exercises",
                column: "ExerciseClassificationId",
                principalTable: "ExerciseCalifications",
                principalColumn: "Id");


        }
    }
}
