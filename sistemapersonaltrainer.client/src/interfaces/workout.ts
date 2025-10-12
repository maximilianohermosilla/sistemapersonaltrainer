import type { Customer } from "./customer"
import type { WorkoutActivity } from "./workout-activity"

export interface Workout {
    id: number
    name: string
    description?: string
    customerId: number
    userId: number
    customer: Customer
    workoutActivities: WorkoutActivity[]
}