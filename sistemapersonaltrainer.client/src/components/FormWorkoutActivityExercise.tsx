import { useState } from "react";
import Autocomplete from "./AutoComplete"
import "./FormWorkoutActivityExercise.css"
import Divider from "./Divider";
import { FaYoutube } from "react-icons/fa6";

interface FormWorkoutActivityExerciseProps {
    index: any;
    exercises: any[],
    selectedLanguage: string;
    onChangeExercise: (element: any) => void;
}

export default function FormWorkoutActivityExercise({ index, exercises, selectedLanguage, onChangeExercise }: FormWorkoutActivityExerciseProps) {
    const [formData, setFormData] = useState<any>({ id: index, exerciseId: 0,  name: '', series: '', repetitions: '', rest: '', shortVideo: '', longVideo: '' });
    const [exercise, setExercise] = useState<any>(null);
    
    const numberExercise = Number(index?.split('_')[1]) + 1;

    const handleChange = (e: React.ChangeEvent<HTMLInputElement> | React.ChangeEvent<HTMLTextAreaElement>) => {
        const { value } = e.target;
        const numericValue = value.replace(/[^0-9]/g, '');
        setFormData({ ...formData, [e.target.name]: numericValue });
        onChangeExercise({ ...formData, [e.target.name]: numericValue });
    };

    const handleSelectExercise = (element: any) => {
        setFormData({ ...formData, exerciseId: element.id, shortVideo: element.urlShortVideo, longVideo: element.urlLongVideo });
        onChangeExercise({ ...formData, exerciseId: element.id, shortVideo: element.urlShortVideo, longVideo: element.urlLongVideo });
        setExercise(element);
    }

    const handleNameExercise = (element: string) => {
        setFormData({ ...formData, name: element });
    }

    return (
        <>
            <Divider />
            <p className="text-xs m-0 p-0">Ejercicio {numberExercise}</p>
            <Autocomplete elements={exercises} selectedLanguage={selectedLanguage} 
                onSelectExercise={handleSelectExercise} onChangeName={handleNameExercise}></Autocomplete>
            <div className="flex justify-start items-center my-2 mb-3 gap-5">
                {exercise && exercise.urlLongVideo && <a href={`${exercise.urlLongVideo}`} target="_blank" rel="noopener noreferrer" 
                    className="flex gap-2 items-center border-1 border-secondary rounded-sm p-1 px-3 text-xs text-secondary hover:bg-blue-100">
                        <FaYoutube />Video 1</a>}
                {exercise && exercise.urlShortVideo && <a href={`${exercise.urlShortVideo}`} target="_blank" rel="noopener noreferrer" 
                    className="flex gap-2 items-center border-1 border-secondary rounded-sm p-1 px-3 text-xs text-secondary hover:bg-secondary">
                        <FaYoutube />Video 2</a>}
            </div>
            <div className="flex justify-between items-center my-1 mb-3 gap-5">
                <div className="flex flex-col ">
                    <label htmlFor={`series_${index}`} className="text-gray-600 text-xs mr-2">Series:</label>
                    <input type="text" id={`series_${index}`} name={`series`} className="border-1 border-gray-400 rounded-sm px-2 text-sm w-20"
                        value={formData?.series} onChange={handleChange} placeholder="Cantidad"/>
                </div>
                <div className="flex flex-col">
                    <label htmlFor={`repetitions_${index}`} className="text-gray-600 text-xs mr-2">Repeticiones:</label>
                    <input type="text" id={`repetitions_${index}`} name={`repetitions`} className="border-1 border-gray-400 rounded-sm px-2 text-sm w-20"
                        value={formData?.repetitions} onChange={handleChange} placeholder="Cantidad"/>
                </div>
                <div className="flex flex-col">
                    <label htmlFor={`rest_${index}`} className="text-gray-600 text-xs mr-2">Descanso (m):</label>
                    <input type="text" id={`rest_${index}`} name={`rest`} className="border-1 border-gray-400 rounded-sm px-2 text-sm w-20"
                        value={formData?.rest} onChange={handleChange} placeholder="Minutos"/>
                </div>
            </div>
        </>
    )
}
