import type { WorkoutActivityExercise } from "./workout-activity-exercise"

export interface WorkoutActivity {
    id: number
    name: string
    description?: string
    workoutId: number
    workoutActivityExercises: WorkoutActivityExercise[]
}