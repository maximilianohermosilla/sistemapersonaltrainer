import { Document, Text, Page, Image, StyleSheet, View } from "@react-pdf/renderer";
import PdfDocumentWorkout from "./PdfDocumentWorkout";

interface PDFProps {
    workout: any;
}

const styles = StyleSheet.create({
    page: {
        padding: 20,
        fontSize: "12px"
    },
    image: {
        width: "200px",
        height: "80px",
    },
    title: {
        fontSize: "14px",
        fontWeight: "bold",
        marginBottom: "5px"
    },
    section: {
        display: "flex",
        flexDirection: "row",
        justifyContent: "space-between",
        gap: "10px",
        marginBottom: "20px"
    },
    sectionRows: {
        display: "flex",
        flexDirection: "column",
        gap: "5px",
        marginBottom: "20px"
    },
});

export default function PdfDocument({ workout }: PDFProps) {

    console.log(workout);
    return (
        <Document>
            <Page size="A4" style={styles.page}>
                <View style={styles.section}>
                    <Image src={workout?.logo} style={styles.image}></Image>
                    <View style={{ paddingRight: "20px"}}>
                        <Text style={styles.title}>Entrenador</Text>
                        <Text>Nombre: {workout.name || ''}</Text>
                        <Text>Email: {workout.email || ''}</Text>
                        <Text>Whatsapp: {workout.whatsapp || ''}</Text>
                    </View>
                </View>

                <View style={styles.sectionRows}>
                    <Text style={styles.title}>Cliente</Text>
                    <Text>Nombre: {workout.customer?.name || ''}</Text>
                    <Text>Email: {workout.customer?.email || ''}</Text>
                    <Text>Whatsapp: {workout.customer?.whatsapp || ''}</Text>
                </View>

                <View style={styles.sectionRows}>
                    <Text style={styles.title}>Entrenamiento</Text>
                    {workout.workoutActivities.map((workoutActivity: any) => {
                        return (
                            <PdfDocumentWorkout key={workoutActivity.id} workoutActivity={workoutActivity}></PdfDocumentWorkout>
                        );
                    })
                    }
                </View>

            </Page>
        </Document>
    )
}
