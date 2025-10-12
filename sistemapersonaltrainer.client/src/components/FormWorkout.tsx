import "./FormWorkout.css"
import { useEffect, useState } from "react";
import { useAuth } from "../context/AuthContext";
import { GetAllExercises } from "../services/exercise-service";
import { LanguageEnum } from "../enums/LanguageEnum";
import { FaMinus, FaPlus } from "react-icons/fa6";
import Spinner from "./Spinner";
import FormWorkoutActivity from "./FormWorkoutActivity";

interface FormWorkoutProps {
    onChangeWorkout: (element: any) => void
}

export default function FormWorkout({ onChangeWorkout }: FormWorkoutProps) {
    const { isLoggedIn } = useAuth();
    const [language, setLanguage] = useState<string>(LanguageEnum.ESPAÑOL);
    const [loading, setLoading] = useState(true);
    const [exercises, setExercises] = useState<any[]>([]);
    const [workoutsActivities, setWorkoutsActivities] = useState<any[]>([]);
    const [quantityWorkouts, setQuantityWorkouts] = useState<number>(1);

    useEffect(() => {
        if (isLoggedIn && exercises?.length == 0) {
            getExercises();
        }
    }, [isLoggedIn]);

    // useEffect(() => {
    //     onChange(quantityWorkouts);
    // }, [quantityWorkouts]);

    const getExercises = async () => {
        const exercisesList = await GetAllExercises();
        setLoading(false);
        setExercises(exercisesList);
    }

    const removeWorkouts = () => {
        event?.preventDefault();
        setQuantityWorkouts(quantityWorkouts > 1 ? quantityWorkouts - 1 : 1)
    }

    const addWorkouts = () => {
        event?.preventDefault();
        setQuantityWorkouts(quantityWorkouts + 1);
    }
    
    const handleChangeWorkout = (element?: any) => {
        const workoutsActivitiesTemp = [...workoutsActivities];
        const index = workoutsActivitiesTemp.findIndex((workout: any) => workout.id === element.id);

        if (index !== -1) {
            workoutsActivitiesTemp[index] = element;
        } else {
            workoutsActivitiesTemp.push(element);
        }
        setWorkoutsActivities(workoutsActivitiesTemp);
        onChangeWorkout(workoutsActivitiesTemp);
    }

    return (
        <>
            {
                loading
                    ? <Spinner text="Cargando ejercicios..."></Spinner>
                    : <section className="workout__container">
                        <h3 className="font-semibold text-gray-800 mb-3">Entrenamiento</h3>
                        <div className="flex justify-between items-center my-3 gap-5">
                            <label htmlFor="language" className="text-gray-600 text-sm mr-2">Búsqueda:</label>
                            <select className=" w-full px-2 py-1 mb-1 rounded-sm border-2 border-gray-400 text-xs text-gray-600"
                                id="language" name="language" value={language} onChange={(e) => setLanguage(e.target.value)} style={{ maxWidth: "185px" }}>
                                <option value={LanguageEnum.ESPAÑOL}>{LanguageEnum.ESPAÑOL}</option>
                                <option value={LanguageEnum.INGLES}>{LanguageEnum.INGLES}</option>
                            </select>
                        </div>

                        <div className="flex justify-between items-center my-3 gap-5">
                            <label htmlFor="quantityWorkouts" className="text-gray-600 text-sm mr-2">Entrenamientos:</label>
                            <button className="button__add__outlined mx-0 rounded-full hover:cursor-pointer hover:opacity-90 hover:shadow-lg shadow-gray-500/40"
                                disabled={quantityWorkouts === 1}
                                onClick={removeWorkouts}>
                                <FaMinus />
                            </button>
                            <input type="number" name="quantityWorkouts" id="quantityWorkouts" className="px-3 w-10"
                                value={quantityWorkouts} onChange={() => setQuantityWorkouts(quantityWorkouts)} />
                            <button className="button__add__outlined mx-0 rounded-full hover:cursor-pointer hover:opacity-90 hover:shadow-lg shadow-gray-500/40"
                                onClick={addWorkouts}>
                                <FaPlus />
                            </button>
                        </div>

                        <div className="my-3">
                            {Array.from({ length: quantityWorkouts }).map((_, index) => (
                                <FormWorkoutActivity key={index} selectedLanguage={language} index={index} 
                                    exercises={exercises} onChangeWorkoutActivity={handleChangeWorkout}></FormWorkoutActivity>                                    
                            ))}
                        </div>
                    </section >
            }
        </>
    )
}
