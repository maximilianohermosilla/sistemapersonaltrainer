import "./Header.css";
import logo from '../assets/logo.png';
import React, { useState } from "react";
import { useAuth } from "../context/AuthContext";
import { FaCartShopping } from "react-icons/fa6";
import { FaMapMarkerAlt } from "react-icons/fa";
import { FiMenu } from "react-icons/fi";
import { BsPersonVcard, BsPersonVcardFill } from "react-icons/bs";
import { GrContact } from "react-icons/gr";
import { MdLogin, MdLogout } from "react-icons/md";

const Header: React.FC = () => {
    const { isLoggedIn, logout } = useAuth();
    const [menuOpen, setMenuOpen] = useState(false);

    const handleLogout = () => {
        logout();
        window.location.reload();
    };

    return (
        <header className="bg-primary shadow-md fixed w-full top-0 left-0 z-50">
            <nav className="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
                <div className="flex justify-between items-center h-16">
                    {/* Logo */}
                    <a href="/" className="flex-shrink-0 hover:cursor-pointer hover:opacity-75 active:ring-2 active:ring-blue-400">
                        <img src={logo} alt="Logo Header" width={100} height={50} />
                    </a>
                

                    {/* Links desktop */}
                    <div className="hidden md:flex space-x-6">
                        <a href="/contact" className="header__link text-gray-600 hover:text-blue-400">
                            <FaMapMarkerAlt />
                        </a>
                        <a href="/orders" className="header__link text-gray-600 hover:text-blue-400">
                            <BsPersonVcardFill />
                        </a>
                        <a onClick={handleLogout} className="header__link relative text-gray-600 hover:text-blue-400">
                            <FaCartShopping />
                        </a>
                    </div>

                    {/* Hamburguesa mobile */}
                    <div className="flex items-center">
                        <button onClick={() => setMenuOpen(!menuOpen)} className="header__link hover:cursor-pointer">
                            <FiMenu color="white"></FiMenu>
                        </button>
                    </div>
                </div>
            </nav>

            {/* Menú desplegable en mobile */}
            {menuOpen && (
                <nav className=" bg-white shadow-md">
                    <div className="px-4 pt-2 pb-3 space-y-2 bg-primary border-t-1 border-gray-800">                        

                        {/* Links */}
                        <a href="/contact" className="flex text-gray-100 hover:text-gray-500 hover:bg-gray-100 w-full gap-3 justify-start items-center py-2 pl-2 rounded-md">
                            <GrContact /> Contacto
                        </a>
                        <a href="/orders" className="flex text-gray-100 hover:text-gray-500 hover:bg-gray-100 w-full gap-3 justify-start items-center py-2 pl-2 rounded-md">
                            <BsPersonVcard /> Historial
                        </a>
                        {isLoggedIn 
                            ? <a onClick={handleLogout} 
                                className="flex text-gray-100 hover:text-gray-500 hover:bg-gray-100 w-full gap-3 justify-start items-center py-2 pl-2 rounded-md cursor-pointer">
                                <MdLogout /> Cerrar sesión</a>
                            : <a href="/" className="flex text-gray-100 hover:text-gray-500 hover:bg-gray-100 w-full gap-3 justify-start items-center py-2 pl-2 rounded-md">
                                <MdLogin /> Ingresar</a>
                        }
                    </div>
                </nav>
            )}
        </header>
    );
};

export default Header;