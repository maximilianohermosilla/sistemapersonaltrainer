import Footer from "../components/Footer";
import { useEffect, useState } from "react";
import { GetAllExercises } from "../services/exercise-service";
import TableExercises from "../components/TableExercises";

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
                <TableExercises data={exercises} onEdit={editExercise} onDelete={deleteExercise}></TableExercises>                
            </section>
            <Footer date={new Date().toISOString()}></Footer>
        </div>
    )
}
