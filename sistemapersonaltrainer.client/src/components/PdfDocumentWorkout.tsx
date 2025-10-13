import { View, Text, StyleSheet, Link } from "@react-pdf/renderer"

interface PdfDocumentoWorkoutProps {
    workoutActivity: any
}

const styles = StyleSheet.create({
    view: {
        marginBottom: 20,
        fontSize: "8px"
    },
    boldText: {
        fontWeight: 'bold',
    },
    tableHeader: {
        flexDirection: "row",
        border: "1px solid #e4e4e4",
        borderColor: "#e4e4e4"
    },
    tableColumn: {
        width: "40%",
        textAlign: "left",
        paddingBottom: "10px",
        paddingTop: "10px",
        marginLeft: "10px",
        borderRight: "1px solid #e4e4e4",
    },
    tableColumn2: {
        width: "20%",
        textAlign: "left",
        paddingBottom: "10px",
        paddingTop: "10px",
        marginLeft: "10px",
        borderRight: "1px solid #e4e4e4",
    },
    tableColumn3: {
        width: "13%",
        textAlign: "center",
        paddingBottom: "10px",
        paddingTop: "10px",
        borderRight: "1px solid #e4e4e4",
    },
    link: {
        textDecoration: "none"
    }
})

export default function PdfDocumentWorkout({ workoutActivity }: PdfDocumentoWorkoutProps) {

    return (
        <>
            <View key={workoutActivity.id} style={styles.view}>
                <View style={[styles.tableHeader, styles.boldText]}>
                    <Text style={styles.tableColumn}>{workoutActivity.name}</Text>
                    <Text style={styles.tableColumn2}>Videos</Text>
                    <Text style={styles.tableColumn3}>Series</Text>
                    <Text style={styles.tableColumn3}>Repeticiones</Text>
                    <Text style={styles.tableColumn3}>Descanso</Text>
                </View>

                {workoutActivity.workoutActivityExercises.map((exercise: any) => (
                    <View key={exercise.id} style={styles.tableHeader}>
                        <Text style={styles.tableColumn}>{exercise.name}</Text>
                        <View style={[styles.tableColumn2, {flexDirection: "row", gap: "10px"}]}>
                            {exercise.shortVideo && <Link src={exercise.shortVideo} style={styles.link}>Demo</Link>}
                            {exercise.shortVideo && exercise.longVideo && <Text>-</Text>}
                            {exercise.longVideo && <Link src={exercise.longVideo} style={styles.link}>Explicación</Link>}
                        </View>
                        <Text style={styles.tableColumn3}>{exercise.series || ''}</Text>
                        <Text style={styles.tableColumn3}>{exercise.repetitions || ''}</Text>
                        <Text style={styles.tableColumn3}>{exercise.restMinutes || ''}</Text>
                    </View>
                ))}
            </View>
        </>
    )
}
