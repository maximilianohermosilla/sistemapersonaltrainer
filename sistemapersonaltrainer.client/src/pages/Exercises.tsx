import { FaPencil, FaTrash } from "react-icons/fa6";
import Footer from "../components/Footer";
import { useEffect, useState } from "react";
import { GetAllExercises } from "../services/exercise-service";

export default function Exercises() {
    const [exercises, setExercises] = useState<any[]>([]);

    useEffect(() => {
        getExercises();
    }, []);

    const getExercises = async () => {
        const exercisesList = await GetAllExercises();
        console.log(exercisesList);
        setExercises(exercisesList);
    }

    const editExercise = (exercise: any) => {
        console.log(exercise);
    }

    const deleteExercise = (exercise: any) => {
        console.log(exercise);
    }


    return (
        <div className="main__container flex flex-col justify-between">
            <section className="p-3">
                <h3 className="font-semibold text-gray-800 mb-3 text-center">Ejercicios</h3>
                <div className="w-full md:px-5 mx-auto" style={{ maxWidth: "1000px" }}>
                    <table className="table-auto w-full">
                        <thead className="text-xs md:text-sm border-1 border-gray-400">
                            <tr>
                                <th className="text-start pl-1 border-r-1 border-gray-400">Ejercicio</th>
                                <th className="text-start pl-1 border-r-1 border-gray-400">Tipo</th>
                                <th className="text-start pl-1 border-r-1 border-gray-400">Zona</th>
                                <th className="text-center pl-1 border-r-1 border-gray-400">Detalle</th>
                            </tr>
                        </thead>
                        <tbody className="text-xs md:text-sm border-1 border-gray-400">
                            {exercises?.map((exercise: any, index: number) => (
                                <tr className="border-b-1 border-gray-400" key={index}>
                                    <td className="text-start px-1 border-r-1 border-gray-400">{exercise.name}</td>
                                    <td className="text-start px-1 border-r-1 border-gray-400">{exercise.exerciseClassification?.description}</td>
                                    <td className="text-start px-1 border-r-1 border-gray-400">{(exercise.muscleGroup?.description)}</td>
                                    <td className="text-center flex px-1 border-r-1 border-gray-400">
                                        <button className="text-xs text-green-800 hover:text-red-500 m-auto" style={{ padding: "5px" }} onClick={() => editExercise(exercise)}>
                                            <FaPencil />
                                        </button>
                                        <button className="text-xs text-red-800 hover:text-red-500 m-auto" style={{ padding: "5px" }} onClick={() => deleteExercise(exercise)}>
                                            <FaTrash />
                                        </button>
                                    </td>
                                </tr>
                            ))}
                            {exercises?.length === 0 && <tr><td colSpan={4} className="w-full text-center py-3 text-gray-400">No se encontraron ejercicios</td></tr>}
                        </tbody>
                    </table>
                </div>
            </section>
            <Footer date={new Date().toISOString()}></Footer>
        </div>
    )
}
