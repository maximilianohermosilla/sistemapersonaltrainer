import "./Administration.css";
import { useAuth } from "../context/AuthContext";
import { useState } from "react";
import Login from "../components/Login";
import showToast from "../services/toast-service";
import { GetAllExercises } from "../services/exercise-service";
import FormExercises from "../components/FormExercises";
import Spinner from "../components/Spinner";

export default function Administration() {
    const [loading, setLoading] = useState(true);
    const [exercises, setExercises] = useState<any[]>([]);
    const { isLoggedIn, login, logout } = useAuth();

    const handleLoginSuccess = (userName?: any, token?: any) => {
        login(userName, token);
        showToast({title: 'Login', description: 'Bienvenido al panel de administración.'});
    };

    const handleLogout = () => {
        logout();
        showToast({ title: 'Login', description: 'Se ha cerrado la sesión.' });
    };

    const getExercises = async () => {
        const exercisesList = await GetAllExercises();
        setLoading(false);
        setExercises(exercisesList);
        console.log(exercisesList)
    }

    if(isLoggedIn && !exercises?.length) {
        getExercises();
    }

    return (
        <div className="main__container w-full flex flex-col justify-between">
            {!isLoggedIn
                ? <section className="flex flex-col justify-center items-center m-auto">
                    <Login onLoginSuccess={handleLoginSuccess}></Login>
                </section>
                : <section className="main__container flex flex-col justify-between h-fit">
                    {loading 
                        ? <Spinner text="Cargando ejercicios..."></Spinner> 
                        : <FormExercises logOut={handleLogout} exercises={exercises}></FormExercises>
                    }
                </section>
            }
        </div>
    )
}
