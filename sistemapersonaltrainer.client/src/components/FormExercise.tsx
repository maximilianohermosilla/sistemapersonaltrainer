import { useState } from "react";
import Autocomplete from "./AutoComplete"
import "./FormExercise.css"
import Divider from "./Divider";

interface FormExerciseProps {
    exercises: any[],
    selectedLanguage: string
}

export default function FormExercise({ exercises, selectedLanguage }: FormExerciseProps) {
    const [formData, setFormData] = useState<any>({ series: '', repetitions: '', rest: '' });

    const handleChange = (e: React.ChangeEvent<HTMLInputElement> | React.ChangeEvent<HTMLTextAreaElement>) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    return (
        <>
            <Divider/>
            <Autocomplete exercises={exercises} selectedLanguage={selectedLanguage}></Autocomplete>
            <div className="flex justify-between items-center my-1 mb-3 gap-5">
                <div className="flex flex-col px-1">
                    <label htmlFor="series" className="text-gray-600 text-xs mr-2">Series:</label>
                    <input type="text" id="series" name="series" className="border-1 border-gray-400 rounded-sm px-2 text-sm w-20"
                        value={formData?.series} onChange={handleChange} />
                </div>
                <div className="flex flex-col px-1">
                    <label htmlFor="repetitions" className="text-gray-600 text-xs mr-2">Repeticiones:</label>
                    <input type="text" id="repetitions" name="repetitions" className="border-1 border-gray-400 rounded-sm px-2 text-sm w-20"
                        value={formData?.repetitions} onChange={handleChange} />
                </div>
                <div className="flex flex-col px-1">
                    <label htmlFor="rest" className="text-gray-600 text-xs mr-2">Descanso:</label>
                    <input type="text" id="rest" name="rest" className="border-1 border-gray-400 rounded-sm px-2 text-sm w-20"
                        value={formData?.rest} onChange={handleChange} />
                </div>
            </div>
        </>
    )
}
