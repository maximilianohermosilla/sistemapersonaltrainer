import './App.css'
import Header from './components/Header'
import { AuthProvider } from './context/AuthContext'
import { Route, Routes } from 'react-router-dom'
import { Toaster } from 'sonner'
import NewWorkout from './pages/NewWorkout'
import Search from './pages/Search'

function App() {
    return (
        <AuthProvider>
            <div className="main__height w-full bg-gray-100">
                <Header></Header>
                <main className="w-full main__height mb-0" style={{ paddingTop: "64px" }}>

                    <Routes>
                        <Route index element={<NewWorkout />} />
                        <Route path="/admin" element={<NewWorkout />} />
                        <Route path="/new-workout" element={<NewWorkout />} />
                        <Route path="/search" element={<Search />} />
                        <Route path="*" element={<NewWorkout />} />
                    </Routes>
                </main>
                <Toaster duration={2000} position="top-right" />
            </div>
        </AuthProvider >
    );
}

export default App
