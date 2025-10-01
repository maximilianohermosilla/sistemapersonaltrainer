import { formatDate } from "../utils/FormatDate";

export default function Footer({ date }: any) {

    return (
        <footer className="bg-gray-900 text-center text-white mt-3 px-0 text-sm py-1">
            Última actualización: {formatDate(date)}
        </footer>
    )
}