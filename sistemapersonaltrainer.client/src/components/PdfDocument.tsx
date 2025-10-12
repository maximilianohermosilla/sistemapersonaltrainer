import { Document, Text, Page, Image, StyleSheet, View } from "@react-pdf/renderer";
import PdfDocumentWorkout from "./PdfDocumentWorkout";
import { formatDate } from "../utils/FormatDate";

interface PDFProps {
    workout: any;
}

const styles = StyleSheet.create({
    page: {
        padding: 20,
        paddingBottom: 40,
        fontSize: "12px"
    },
    image: {
        width: "200px",
        height: "80px",
    },
    title: {
        fontSize: "14px",
        fontWeight: "bold",
        marginBottom: "3px"
    },
    section: {
        display: "flex",
        flexDirection: "row",
        justifyContent: "space-between",
        gap: "10px",
        marginBottom: "10px"
    },
    sectionRows: {
        display: "flex",
        flexDirection: "column",
        gap: "8px",
        marginBottom: "20px"
    },
    paddingRight: {
        paddingRight: "10px",
    }
});

export default function PdfDocument({ workout }: PDFProps) {

    console.log(workout);
    return (
        <Document>
            <Page size="A4" style={styles.page}>
                <View style={styles.section}>
                    {workout?.logo && <Image src={workout?.logo} style={styles.image}></Image>}
                    <View style={[styles.sectionRows, styles.paddingRight, {width: "200px"}]}>
                        <Text style={styles.title}>Entrenador</Text>
                        <Text>Nombre: {workout.name || ''}</Text>
                        <Text>Email: {workout.email || ''}</Text>
                        <Text>Whatsapp: {workout.whatsapp || ''}</Text>
                    </View>
                </View>

                <View style={styles.section}>
                    <View style={styles.sectionRows}>
                        <Text style={styles.title}>Cliente</Text>
                        <Text>Nombre: {workout.customer?.name || ''}</Text>
                        <Text>Email: {workout.customer?.email || ''}</Text>
                        <Text>Whatsapp: {workout.customer?.whatsapp || ''}</Text>
                    </View>
                <View style={[styles.sectionRows, styles.paddingRight, {width: "200px"}]}>
                        <Text style={styles.title}>Fecha: </Text>
                        <Text>{formatDate(new Date().toISOString())}</Text>
                    </View>
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
