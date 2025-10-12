import "./FormMain.css";
import { FaRegSave } from "react-icons/fa";
import { useEffect, useState } from "react";
import showToast from "../services/toast-service";
import logo from "../assets/logo.png";
import InputFile from "./InputFile";
import { GetParameterByKey, UpdateParameter } from "../services/parameter-service";
import { ParameterEnum } from "../enums/parameter";
import FormWorkout from "./FormWorkout";
import FormCustomer from "./FormCustomer";
import Divider from "./Divider";
import { FaFilePdf } from "react-icons/fa6";

export default function FormMain() {
    const [formData, setFormData] = useState<any>({ logo: '', name: '', email: '', whatsapp: '' });
    const [error, setError] = useState<string | null>(null);
    const [workoutActivities, setWorkoutActivities] = useState<any[]>([]);
    const [customer, setCustomer] = useState<any>(null);

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

    const handleChangeWorkout = (event: any) => {
        setWorkoutActivities(event);
    }
    
    const handleChangeCustomer = (event: any) => {
        setCustomer(event);
    }

    const handleSubmit = async (e: React.FormEvent) => {        
        e.preventDefault();
        setError(null);

        if (!formData.name) { return setError('Por favor, ingrese el nombre de entrenador.'); }
        if (!customer || customer.name == '') { return setError('Por favor, ingrese el nombre del cliente.'); }
        if (!workoutActivities || workoutActivities.length === 0) { return setError('Por favor, ingrese al menos un ejercicio.'); }

        await updateParameters();

        showToast({ title: 'Éxito', description: 'Se han guardado los cambios.' });
    }

    const updateParameters = async () => {
        await UpdateParameter({ key: ParameterEnum.LOGO, value: formData?.logo });
        await UpdateParameter({ key: ParameterEnum.NAME, value: formData?.name });
        await UpdateParameter({ key: ParameterEnum.WHATSAPP, value: formData?.whatsapp });
        await UpdateParameter({ key: ParameterEnum.EMAIL, value: formData?.email });
    }

    const previewWorkout = () => {

    }


    return (
        <>
            <form className="flex flex-col">
                <img src={formData?.logo ? formData?.logo : logo} alt="Logo" width={320} height={100}
                    className="m-auto my-3 shadow-lg shadow-gray-800 object-fill h-35" />
                <div className="parameters__container m-auto mt-1">
                    <Divider />

                    <h3 className="font-semibold text-gray-800 mb-3">Entrenador</h3>
                    <div className="flex justify-between items-center my-3 gap-5">
                        <label htmlFor="logo" className="text-gray-600 text-sm mr-2">Logo:</label>
                        <InputFile onFileChange={handleFileChange} />
                    </div>
                    <div className="flex justify-between items-center my-3 gap-5">
                        <label htmlFor="name" className="text-gray-600 text-sm mr-2">Nombre:</label>
                        <input type="text" id="name" name="name" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                            value={formData?.name} onChange={handleChange} />
                    </div>
                    <div className="flex justify-between items-center my-3 gap-5">
                        <label htmlFor="email" className="text-gray-600 text-sm mr-2">Correo:</label>
                        <input type="text" id="email" name="email" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                            value={formData?.email} onChange={handleChange} />
                    </div>
                    <div className="flex justify-between items-center my-3 gap-5">
                        <label htmlFor="whatsapp" className="text-gray-600 text-sm mr-2">Whatsapp:</label>
                        <input type="text" id="whatsapp" name="whatsapp" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                            value={formData?.whatsapp} onChange={handleChange} />
                    </div>
                    <Divider />

                    <FormCustomer onChangeCustomer={handleChangeCustomer}></FormCustomer>
                    <Divider />

                    <FormWorkout onChangeWorkout={handleChangeWorkout}></FormWorkout>
                    
                    {error && <p className="text-danger text-center text-sm font-semibold px-2">{error}</p>}
                </div>

                <footer className="parameters__container flex gap-3 justify-between my-5 mx-auto">
                    <button className="button__primary__outlined flex items-center gap-1" onClick={previewWorkout}><FaFilePdf /> Visualizar</button>
                    <button className="button__primary flex items-center gap-3" onClick={handleSubmit}><FaRegSave />Guardar</button>
                </footer>
            </form>
        </>
    )
}
