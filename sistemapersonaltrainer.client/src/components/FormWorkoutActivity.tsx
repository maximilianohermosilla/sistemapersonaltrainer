import { useEffect, useState } from "react";
import { FaMinus, FaPlus } from "react-icons/fa6";
import FormExercise from "./FormExercise";

interface FormWorkoutActivityProps {
    index: number;
    selectedLanguage: string;
    exercises: any[],
    onChange?: (element: any) => void;
}

export default function FormWorkoutActivity({ index, selectedLanguage, exercises }: FormWorkoutActivityProps) {
    const [quantityExercises, setQuantityExercises] = useState<number>(1);
    const [formData, setFormData] = useState<any>({ nameworkout: `Entrenamiento ${index+1}`, email: '', whatsapp: '' });

    useEffect(() => {
        console.log(selectedLanguage);
    }, [selectedLanguage])

    const handleChange = (e: React.ChangeEvent<HTMLInputElement> | React.ChangeEvent<HTMLTextAreaElement>) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    const removeExercise = () => {
        event?.preventDefault();
        setQuantityExercises(quantityExercises > 1 ? quantityExercises - 1 : 1)
    }

    const addExercise = () => {
        event?.preventDefault();
        setQuantityExercises(quantityExercises + 1);
    }

    return (
        <article className="border-1 border-gray-200 rounded-md p-2 py-4 mb-5 shadow-md shadow-gray-600/40">
            <input type="text" id="nameworkout" name="nameworkout" className="border-1 border-gray-400 rounded-sm px-2 text-sm w-full py-1"
                value={formData?.nameworkout} onChange={handleChange} />

            <div className="flex justify-between items-center my-3 gap-5 px-3">
                <label htmlFor="quantityWorkouts" className="text-gray-600 text-xs mr-2">Ejercicios:</label>
                <button className="button__add__outlined mx-0 rounded-full hover:cursor-pointer hover:opacity-90 hover:shadow-lg shadow-gray-500/40 text-xs"
                    disabled={quantityExercises === 1}
                    onClick={removeExercise}>
                    <FaMinus />
                </button>
                <input type="number" name="quantityWorkouts" id="quantityWorkouts" className="px-3 w-10 text-xs"
                    value={quantityExercises} onChange={() => setQuantityExercises(quantityExercises)} />
                <button className="button__add__outlined mx-0 rounded-full hover:cursor-pointer hover:opacity-90 hover:shadow-lg shadow-gray-500/40 text-xs"
                    onClick={addExercise}>
                    <FaPlus />
                </button>
            </div>
            <div className="my-3">
                {Array.from({ length: quantityExercises }).map((_, index) => (
                    <FormExercise key={index} exercises={exercises} selectedLanguage={selectedLanguage}></FormExercise>
                ))}
            </div>
        </article>
    )
}
