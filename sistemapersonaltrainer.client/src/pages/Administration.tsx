import "./Administration.css";
import { useAuth } from "../context/AuthContext";
import { useState } from "react";
import Login from "../components/Login";
import { MdLogout } from "react-icons/md";
import { FaRegSave } from "react-icons/fa";
import showToast from "../services/toast-service";

export default function Administration() {
    const [formData, setFormData] = useState<any>({ delay: '', address: '', phone: '', email: '', whatsapp: '', instagram: '', schedules: '' });
    const [error, setError] = useState<string | null>(null);
    const { isLoggedIn, login, logout } = useAuth();

    const handleLoginSuccess = (userName?: any, token?: any) => {
        login(userName, token);
        showToast({title: 'Login', description: 'Bienvenido al panel de administración.'});
    };

    const handleLogout = () => {
        logout();
        showToast({title: 'Login', description: 'Se ha cerrado la sesión.'});
    };

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

        showToast({title: 'Administración', description: 'Parámetros actualizados correctamente.'});
    }

    return (
        <div className="main__container w-full flex flex-col justify-between">
            {!isLoggedIn
                ? <section className="flex flex-col justify-center items-center m-auto">
                    <Login onLoginSuccess={handleLoginSuccess}></Login>
                </section>
                : <section className="main__container flex flex-col justify-between h-fit">
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
                        </div>
                        {error && <p className="text-danger text-center text-sm font-semibold px-2">{error}</p>}
                    </form>
                    <footer className="flex gap-3">
                        <button className="button__danger__outlined flex items-center gap-1 my-5 mx-auto" onClick={handleLogout}><MdLogout />Cerrar sesión</button>
                        <button className="button__primary flex items-center gap-3 my-5 mx-auto" onClick={handleSubmit}><FaRegSave />Guardar</button>
                    </footer>
                </section>
            }
        </div>
    )
}
