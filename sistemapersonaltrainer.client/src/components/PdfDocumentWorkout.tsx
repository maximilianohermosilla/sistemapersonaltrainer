import { View, Text, StyleSheet } from "@react-pdf/renderer"

interface PdfDocumentoWorkoutProps {
    workoutActivity: any
}

const styles = StyleSheet.create({
    view: {
        marginBottom: 20
    }
})

export default function PdfDocumentWorkout({ workoutActivity }: PdfDocumentoWorkoutProps) {

    console.log(workoutActivity);

    return (
        <>
            <View key={workoutActivity.id} style={styles.view}>
                <Text style={{ fontWeight: "bold", marginBottom: "5px" }}>{workoutActivity.name}</Text>
                {workoutActivity.exercises.map((exercise: any) => (
                    <View key={exercise.id}>
                        <Text>{exercise.name}</Text>
                    </View>
                ))}
            </View>
        </>
    )
}
