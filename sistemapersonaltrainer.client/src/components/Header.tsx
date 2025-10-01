import "./Header.css";
import React, { useState } from "react";
import logo from '../assets/logo.png';
import { FaCartShopping } from "react-icons/fa6";
import { FaMapMarkerAlt } from "react-icons/fa";
import { FiMenu } from "react-icons/fi";
import { BsPersonVcardFill } from "react-icons/bs";

const Header: React.FC = () => {
    const [menuOpen, setMenuOpen] = useState(false);


    return (
        <header className="bg-white shadow-md fixed w-full top-0 left-0 z-50">
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
                        <a href="/shopping-cart" className="header__link relative text-gray-600 hover:text-blue-400">
                            <FaCartShopping />
                        </a>
                    </div>

                    {/* Hamburguesa mobile */}
                    <div className="md:hidden flex items-center">
                        <button onClick={() => setMenuOpen(!menuOpen)} className="header__link hover:cursor-pointer">
                            <FiMenu></FiMenu>
                        </button>
                    </div>
                </div>
            </nav>

            {/* Menú desplegable en mobile */}
            {menuOpen && (
                <nav className="md:hidden bg-white shadow-md">
                    <div className="px-4 pt-2 pb-3 space-y-2">                        

                        {/* Links */}
                        <a href="/contact" className="flex text-gray-700 hover:text-gray-500 hover:bg-gray-100 w-full gap-3 justify-start items-center py-2 pl-1 rounded-md">
                            <FaMapMarkerAlt /> Ubicación
                        </a>
                        <a href="/orders" className="flex text-gray-700 hover:text-gray-500 hover:bg-gray-100 w-full gap-3 justify-start items-center py-2 pl-1 rounded-md">
                            <BsPersonVcardFill /> Pedidos
                        </a>
                        <a href="/shopping-cart" className="flex text-gray-700 hover:text-gray-500 hover:bg-gray-100 w-full gap-3 justify-start items-center py-2 pl-1 rounded-md">
                            <FaCartShopping /> Carrito
                        </a>
                    </div>
                </nav>
            )}
        </header>
    );
};

export default Header;