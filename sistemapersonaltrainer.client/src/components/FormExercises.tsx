import { MdLogout } from "react-icons/md";
import { FaRegSave } from "react-icons/fa";
import Autocomplete from "../components/AutoComplete";
import { useEffect, useState } from "react";
import showToast from "../services/toast-service";
import logo from "../assets/logo.png";
import InputFile from "./InputFile";
import { GetParameterByKey, UpdateParameter } from "../services/parameter-service";
import { ParameterEnum } from "../enums/parameter";

interface FormExercisesProps {
    exercises: any[],
    logOut: () => void
}
export default function FormExercises({ exercises, logOut }: FormExercisesProps) {
    const [formData, setFormData] = useState<any>({ logo: '', name: '', email: '', whatsapp: '' });
    const [error, setError] = useState<string | null>(null);

    const handleChange = (e: React.ChangeEvent<HTMLInputElement> | React.ChangeEvent<HTMLTextAreaElement>) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    useEffect(() => {
        getParameters();
    }, []);

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

    const handleFileChange = (event: any) => {
        const file = event.target.files[0];

        if (file) {
            const reader = new FileReader();

            reader.onloadend = () => {
                const base64String = reader.result;
                setFormData({ ...formData, logo: base64String });
            };

            reader.readAsDataURL(file);
        }
    };

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError(null);

        if (!formData.name) {
            setError('Por favor, ingresa un nombre.');
            return;
        }

        await UpdateParameter({ key: ParameterEnum.LOGO, value: formData?.logo });
        await UpdateParameter({ key: ParameterEnum.NAME, value: formData?.name });
        await UpdateParameter({ key: ParameterEnum.WHATSAPP, value: formData?.whatsapp });
        await UpdateParameter({ key: ParameterEnum.EMAIL, value: formData?.email });

        showToast({ title: 'Administración', description: 'Parámetros actualizados correctamente.' });
    }


    return (
        <>
            <form className="flex flex-col">
                <img src={formData?.logo ? formData?.logo : logo} alt="Logo" width={300} height={100}
                    className="m-auto mt-3 mb-5 shadow-lg shadow-gray-800 object-fill h-35" />
                <div className="parameters__container m-auto mt-5">
                    <div className="flex justify-between items-center my-3">
                        <label htmlFor="logo" className="text-gray-600 text-sm mr-2">Logo:</label>
                        <InputFile onFileChange={handleFileChange} />
                    </div>
                    <div className="flex justify-between items-center my-3">
                        <label htmlFor="name" className="text-gray-600 text-sm mr-2">Nombre:</label>
                        <input type="text" id="name" name="name" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                            value={formData?.name} onChange={handleChange} />
                    </div>
                    <div className="flex justify-between items-center my-3">
                        <label htmlFor="email" className="text-gray-600 text-sm mr-2">Correo:</label>
                        <input type="text" id="email" name="email" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                            value={formData?.email} onChange={handleChange} />
                    </div>
                    <div className="flex justify-between items-center my-3">
                        <label htmlFor="whatsapp" className="text-gray-600 text-sm mr-2">Whatsapp:</label>
                        <input type="text" id="whatsapp" name="whatsapp" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                            value={formData?.whatsapp} onChange={handleChange} />
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
    )
}
