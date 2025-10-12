import { useState } from 'react';
import './FormCustomer.css'

interface FormCustomerProps {
    onChangeCustomer: (element: any) => void
}

export default function FormCustomer({ onChangeCustomer }: FormCustomerProps) {
    const [formData, setFormData] = useState<any>({ name: '', email: '', whatsapp: '' });

    const handleChange = (e: React.ChangeEvent<HTMLInputElement> | React.ChangeEvent<HTMLTextAreaElement>) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
        onChangeCustomer({ ...formData, [e.target.name]: e.target.value });
    };

    return (
        <section className="customer__container">
            <h3 className="font-semibold text-gray-800 mb-3">Cliente</h3>
            <div className="flex justify-between items-center my-3 gap-5">
                <label htmlFor="name" className="text-gray-600 text-sm mr-2">Nombre:</label>
                <input type="text" id="name-customer" name="name" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                    value={formData?.name} onChange={handleChange} placeholder="Nombre"/>
            </div>
            <div className="flex justify-between items-center my-3 gap-5">
                <label htmlFor="email" className="text-gray-600 text-sm mr-2">Correo:</label>
                <input type="text" id="email-customer" name="email" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                    value={formData?.email} onChange={handleChange} placeholder="Correo"/>
            </div>
            <div className="flex justify-between items-center my-3 gap-5">
                <label htmlFor="whatsapp" className="text-gray-600 text-sm mr-2">Whatsapp:</label>
                <input type="text" id="whatsapp-customer" name="whatsapp" className="border-1 border-gray-400 rounded-sm px-2 text-sm"
                    value={formData?.whatsapp} onChange={handleChange} placeholder="Whatsapp"/>
            </div>
        </section>
    )
}
