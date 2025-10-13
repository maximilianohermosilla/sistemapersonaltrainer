import showToast from "./toast-service";

const apiUrl = import.meta.env.DEV ? import.meta.env.VITE_API_URL : '';

export async function GetAllWorkoutsByCustomer(customer: string) {
    const response = await fetch(`${apiUrl}/api/workout/getallbycustomer/${customer}`);
    if (response.ok) {
        const data = await response?.json().catch((err: any) => showToast({ title: 'Error', description: err.message, error: true }));
        return data;
    }
    else {
        showToast({ title: 'Error', description: response.statusText != '' ? response.statusText : `Ocurrió un error al obtener los datos para el cliente ${customer}.`, error: true });
    }
}

export async function GetAllWorkoutsByUser() {
    const token = localStorage.getItem('authToken');

    const response = await fetch(`${apiUrl}/api/workout/getallbyuser/`, {
        method: 'GET',
        headers: {
            'Authorization': `Bearer ${token}`,
            'Content-Type': 'application/json',
        },
    });

    if (response.ok) {
        const data = await response?.json().catch((err: any) => showToast({ title: 'Error', description: err.message, error: true }));
        return data;
    }
    else {
        showToast({ title: 'Error', description: response.statusText != '' ? response.statusText : `Ocurrió un error al obtener los workouts`, error: true });
    }
}

export async function CreateWorkout(workout: any) {
    const token = localStorage.getItem('authToken');

    const response = await fetch(`${apiUrl}/api/workout/Create`, {
        method: 'POST',
        headers: {
            'Authorization': `Bearer ${token}`,
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(workout)
    });

    if (response.ok) {
        const data = await response.json().catch((err: any) => showToast({ title: 'Error', description: err.message, error: true }));
        return data;
    }
    else {
        showToast({ title: 'Error', description: response.statusText != '' ? response.statusText : `Ocurrió un error al crear el workout ${workout?.customer}.`, error: true });
    }
}