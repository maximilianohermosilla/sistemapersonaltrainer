export default function InputFile({onFileChange}: any) {
    return (
        <div className="relative" style={{ maxWidth: "180px" }}>
            <label title="Click to upload" htmlFor="logo"
                className="cursor-pointer flex items-center gap-4 px-6 py-1 text-sm w-50
                                        before:border-gray-400/60 hover:before:border-gray-900 group before:bg-white-100 before:absolute 
                                        before:inset-0 before:rounded-sm before:border-1 before:transition-transform before:duration-300">
                <div className="w-max relative">
                    <svg className="h-4 w-4" fill="none" viewBox="0 0 24 24" stroke="grey">
                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M4 16v1a3 3 0 003 3h10a3 3 0 003-3v-1m-4-8l-4-4m0 0L8 8m4-4v12" />
                    </svg>
                </div>
                <div className="relative">
                    <span className="block text-xs relative text-gray-400 group-hover:text-gray-900">
                        Seleccione archivo
                    </span>
                </div>
            </label>
            <input className="hidden" type="file" accept="image/*" id="logo" name="logo" placeholder="" onChange={onFileChange} />
        </div>
    )
}
