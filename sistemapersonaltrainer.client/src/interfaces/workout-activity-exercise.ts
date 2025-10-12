export interface WorkoutActivityExercise {
    id: number
    name: string
    description?: string
    workoutActivityId: number
    exerciseId: number
    series?: number
    repetitions?: number
    restMinutes?: number
}