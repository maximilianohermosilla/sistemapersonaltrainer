import { useState, useEffect } from 'react';
import { LanguageEnum } from '../enums/LanguageEnum';

interface AutoCompleteProps{
    exercises: any[],
    selectedLanguage: string
}

export default function Autocomplete({ exercises, selectedLanguage }: AutoCompleteProps) {
    const [language, setLanguage] = useState<string>(selectedLanguage);
    const [inputValue, setInputValue] = useState('');
    const [suggestions, setSuggestions] = useState<any[]>([]);

    useEffect(() => {
        if (inputValue.length > 0) {
            const optionsLanguage = exercises?.map((o: any) => language == LanguageEnum.ESPAÑOL ? o.description : o.name);
            const filtered = optionsLanguage?.filter((option: any) =>
                option?.toLowerCase().includes(inputValue.toLowerCase())
            );
            setSuggestions(filtered);
        } else {
            setSuggestions([]);
        }
    }, [inputValue]);

    useEffect(() => {
        setLanguage(selectedLanguage);
    }, [selectedLanguage])

    const handleInputChange = (event: any) => {
        setInputValue(event.target.value);
    };

    const handleSuggestionClick = (suggestion: any) => {
        console.log(suggestion);
        setInputValue(suggestion);
        setSuggestions([]);
        setSuggestions([]);
    };

    return (
        <div>
            <input
                className="w-full px-2 py-1 mb-1 rounded-sm my-3 text-sm"
                type="text"
                value={inputValue}
                onChange={handleInputChange}
                placeholder="Buscar ejercicio..."
            />
            {suggestions.length > 1 && (
                <ul className="px-2">
                    {suggestions.map((suggestion, index) => (
                        <li className="mb-1 cursor-pointer text-gray-500" key={index} onClick={() => handleSuggestionClick(suggestion)}>
                            {suggestion}
                            <hr className="border-t border-gray-300 my-1" />
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
}