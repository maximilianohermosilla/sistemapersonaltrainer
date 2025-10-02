import showToast from "./toast-service";

const apiUrl = import.meta.env.DEV ? import.meta.env.VITE_API_URL : '';

export async function GetAllExercises() {
    const response = await fetch(`${apiUrl}/api/Exercise/GetAll`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }
    });

    if (response.ok) {
        const data = await response.json().catch((err: any) => showToast({title: 'Error', description: err.message, error: true}));
        return data;
    }
    else {
        showToast({ title: 'Error', description: response.statusText != '' ? response.statusText : "Ocurrió un error al obtener los ejercicios.", error: true });
    }
}