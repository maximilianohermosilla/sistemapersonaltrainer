import "./Administration.css";
import { useAuth } from "../context/AuthContext";
import Login from "../components/Login";
import showToast from "../services/toast-service";
import FormMain from "../components/FormMain";

export default function Administration() {
    const { isLoggedIn, login } = useAuth();

    const handleLoginSuccess = (userName?: any, token?: any) => {
        login(userName, token);
        showToast({ title: 'Login', description: 'Bienvenido al panel de administración.' });
    };

    return (
        <div className="main__container w-full flex flex-col justify-between">
            {!isLoggedIn
                ? <section className="flex flex-col justify-center items-center m-auto">
                    <Login onLoginSuccess={handleLoginSuccess}></Login>
                </section>
                : <section className="main__container flex flex-col justify-between h-fit">
                    <FormMain></FormMain>
                </section>
            }
        </div>
    )
}
