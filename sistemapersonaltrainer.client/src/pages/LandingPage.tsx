import Footer from "../components/Footer";

export default function LandingPage() {

    return (
        <div className="main__container flex flex-col justify-between">
            <section className="pt-3">
                
            </section>
            <Footer date={new Date().toISOString()}></Footer>
        </div>
    )
}
