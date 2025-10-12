import './App.css'
import Header from './components/Header'
import { AuthProvider } from './context/AuthContext'
import { Route, Routes } from 'react-router-dom'
import { Toaster } from 'sonner'
import Administration from './pages/Administration'

function App() {
    return (
        <AuthProvider>
            <div className="main__height w-full bg-gray-100">
                <Header></Header>
                <main className="w-full main__height mb-0" style={{ paddingTop: "64px" }}>

                    <Routes>
                        <Route index element={<Administration />} />
                        <Route path="/admin" element={<Administration />} />
                        <Route path="*" element={<Administration />} />
                    </Routes>
                </main>
                <Toaster duration={2000} position="top-right" />
            </div>
        </AuthProvider >
    );
}

export default App
