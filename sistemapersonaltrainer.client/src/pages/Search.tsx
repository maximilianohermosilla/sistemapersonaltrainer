import { PDFDownloadLink, PDFViewer } from "@react-pdf/renderer";
import { useAuth } from "../context/AuthContext";
import "./Search.css";
import logo from "../assets/logo.png";
import PdfDocument from "../components/PdfDocument";
import { FaFilePdf } from "react-icons/fa6";
import { useEffect, useState } from "react";
import { GetAllWorkoutsByUser } from "../services/workout-service";
import { GetParameterByKey } from "../services/parameter-service";
import { ParameterEnum } from "../enums/parameter";
import { formatDate } from "../utils/FormatDate";

export default function Search() {
    const { isLoggedIn } = useAuth();
    const [workout, setWorkout] = useState<any>(null);
    const [workouts, setWorkouts] = useState<any[]>([]);
    const [formData, setFormData] = useState<any>({ logo: '', name: '', email: '', whatsapp: '', customer: {}, workoutActivities: [] });

    useEffect(() => {
        if (isLoggedIn) {
            getParameters();
            getAllWorkoutsByUser();
        }
        //setWorkouts([{ name: "Entrenamiento 1", customer: { name: "Cliente 1" }, createdAt: "2023-01-01" , workoutActivities: []}]);        
    }, [isLoggedIn])

    const getParameters = async () => {
        const logoParameter = await GetParameterByKey(ParameterEnum.LOGO);
        const nameParameter = await GetParameterByKey(ParameterEnum.NAME);
        const emailParameter = await GetParameterByKey(ParameterEnum.EMAIL);
        const whatsappParameter = await GetParameterByKey(ParameterEnum.WHATSAPP);

        setFormData({
            ...formData,
            logo: logoParameter?.value || '',
            name: nameParameter?.value || '',
            email: emailParameter?.value || '',
            whatsapp: whatsappParameter?.value || ''
        })
    }

    const getAllWorkoutsByUser = async () => {
        const response = await GetAllWorkoutsByUser();
        setWorkouts(response);
    }

    const previewWorkout = (element: any) => {
        setWorkout(undefined);
        setTimeout(() => {
            setWorkout({...element, logo: formData?.logo, name: formData?.name, email: formData?.email, whatsapp: formData?.whatsapp });            
        }, 300);
    }

    return (
        <div className="main__container w-full flex flex-col justify-between">
            {!isLoggedIn
                ? <section className="flex flex-col justify-center items-center m-auto">
                    <input type="text" placeholder="Buscar..." className="mx-auto w-200"></input>
                </section>
                : <section className="main__container flex flex-col justify-between h-fit">
                    <section className="w-full flex flex-col h-full p-3 gap-5">
                        {/* <input type="text" placeholder="Buscar..." className="mx-auto"></input> */}
                        <div className="flex flex-col md:flex-row justify-center gap-3 mx-auto">
                            <img src={formData?.logo ? formData?.logo : logo} alt="Logo" width={200} height={40}
                                className="shadow-lg shadow-gray-800 object-fill" />
                            <div className="text-sm md:pt-2">
                                <p className="mb-0"><strong>Nombre: </strong>{formData?.name}</p>
                                <p className="mb-0"><strong>Email: </strong>{formData?.email}</p>
                                <p className="mb-0"><strong>Whatsapp: </strong>{formData?.whatsapp}</p>
                            </div>
                        </div>

                        <div className="w-full md:px-5 mx-auto" style={{ maxWidth: "1000px" }}>
                            <table className="table-auto w-full">
                                <thead className="text-xs md:text-sm border-1 border-gray-400">
                                    <tr>
                                        <th className="text-start pl-1 border-r-1 border-gray-400">Entrenamiento</th>
                                        <th className="text-start pl-1 border-r-1 border-gray-400">Cliente</th>
                                        <th className="text-start pl-1 border-r-1 border-gray-400">Fecha</th>
                                        <th className="text-center pl-1 border-r-1 border-gray-400">Detalle</th>
                                    </tr>
                                </thead>
                                <tbody className="text-xs md:text-sm border-1 border-gray-400">
                                    {workouts?.map((workout: any, index: number) => (
                                        <tr className="border-b-1 border-gray-400" key={index}>
                                            <td className="text-start px-1 border-r-1 border-gray-400">{workout.name}</td>
                                            <td className="text-start px-1 border-r-1 border-gray-400">{workout.customer?.firstName}</td>
                                            <td className="text-start px-1 border-r-1 border-gray-400">{formatDate(workout.createdAt)}</td>
                                            <td className="text-center px-1 border-r-1 border-gray-400">
                                                <button className="text-xs text-red-800 hover:text-red-500" onClick={() => previewWorkout(workout)}>
                                                    <FaFilePdf />
                                                </button>
                                            </td>
                                        </tr>
                                    ))}
                                    {workouts?.length === 0 && <tr><td colSpan={4} className="w-full text-center py-3 text-gray-400">No se encontraron entrenamientos</td></tr>}
                                </tbody>
                            </table>
                        </div>


                        {workout && <PDFViewer className="h-200 max-h-screen shadow-md shadow-gray-500/50">
                            <PdfDocument workout={workout}></PdfDocument>
                        </PDFViewer>}
                        {workout && <PDFDownloadLink document={<PdfDocument workout={workout}></PdfDocument>} fileName="download.pdf">
                            {({ loading }) => loading
                                ? 'Descargando...'
                                : <button className="button__primary__outlined flex items-center gap-1 m-auto"><FaFilePdf /> Descargar</button>
                            }
                        </PDFDownloadLink>}
                    </section>
                </section>
            }
        </div>
    )
}
