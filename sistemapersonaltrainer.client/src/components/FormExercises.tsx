import { MdLogout } from "react-icons/md";
import { FaRegSave } from "react-icons/fa";
import Autocomplete from "../components/AutoComplete";
import { useState } from "react";
import showToast from "../services/toast-service";
import Spinner from "./Spinner";

interface FormExercisesProps {
    exercises: any[],
    logOut: () => void
}
export default function FormExercises({ exercises, logOut }: FormExercisesProps) {
    const [loading, setLoading] = useState(false);
    const [formData, setFormData] = useState<any>({ delay: '', address: '', phone: '', email: '', whatsapp: '', instagram: '', schedules: '' });
    const [error, setError] = useState<string | null>(null);

    const handleChange = (e: React.ChangeEvent<HTMLInputElement> | React.ChangeEvent<HTMLTextAreaElement>) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError(null);

        if (!formData.delay) {
            setError('Por favor, ingresa tiempo de demora.');
            return;
        }

        showToast({ title: 'Administración', description: 'Parámetros actualizados correctamente.' });
    }


    return (
        <>
            {loading ? <Spinner text="Cargando..." />
                : <>
                    <form className="">
                        <h1 className="text-primary text-2xl font-semibold w-full text-center mb-1 mt-5">Administración</h1>
                        <div className="parameters__container m-auto">
                            <div className="flex justify-between items-center my-3">
                                <label htmlFor="address" className="text-gray-600 text-sm mr-2">Dirección:</label>
                                <input type="text" id="address" name="address" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                                    value={formData?.address} onChange={handleChange} />
                            </div>
                            <div className="flex justify-between items-center my-3">
                                <label htmlFor="email" className="text-gray-600 text-sm mr-2">Correo:</label>
                                <input type="text" id="email" name="email" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                                    value={formData?.email} onChange={handleChange} />
                            </div>
                            <div className="flex justify-between items-center my-3">
                                <label htmlFor="phone" className="text-gray-600 text-sm mr-2">Teléfono:</label>
                                <input type="text" id="phone" name="phone" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                                    value={formData?.phone} onChange={handleChange} />
                            </div>
                            <div className="flex justify-between items-center my-3">
                                <label htmlFor="instagram" className="text-gray-600 text-sm mr-2">Instagram:</label>
                                <input type="text" id="instagram" name="instagram" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                                    value={formData?.instagram} onChange={handleChange} />
                            </div>
                            <div className="flex justify-between items-center my-3">
                                <label htmlFor="whatsapp" className="text-gray-600 text-sm mr-2">Whatsapp:</label>
                                <input type="text" id="whatsapp" name="whatsapp" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                                    value={formData?.whatsapp} onChange={handleChange} />
                            </div>
                            <div className="flex justify-between items-center my-3">
                                <label htmlFor="schedules" className="text-gray-600 text-sm mr-2">Horarios:</label>
                                {/* <input type="text" id="schedules" name="schedules" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                                    value={formData?.schedules} onChange={handleChange} /> */}
                                <textarea id="schedules" name="schedules"
                                    className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                                    value={formData?.schedules}
                                    onChange={handleChange}
                                    rows={5}
                                    cols={30}
                                />
                            </div>
                            {exercises?.length > 0 && <Autocomplete allOptions={exercises?.map((e: any) => e.name)}></Autocomplete>}
                        </div>
                        {error && <p className="text-danger text-center text-sm font-semibold px-2">{error}</p>}
                    </form>
                    <footer className="flex gap-3">
                        <button className="button__danger__outlined flex items-center gap-1 my-5 mx-auto" onClick={logOut}><MdLogout />Cerrar sesión</button>
                        <button className="button__primary flex items-center gap-3 my-5 mx-auto" onClick={handleSubmit}><FaRegSave />Guardar</button>
                    </footer>
                </>
            }
        </>
    )
}
