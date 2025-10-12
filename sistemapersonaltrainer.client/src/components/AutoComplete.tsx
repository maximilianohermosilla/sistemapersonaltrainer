import { useState, useEffect } from 'react';
import { LanguageEnum } from '../enums/LanguageEnum';

interface AutoCompleteProps{
    elements: any[],
    selectedLanguage: string,
    onSelectExercise: (element: any) => void,
    onChangeName: (element: string) => void
}

export default function Autocomplete({ elements, selectedLanguage, onSelectExercise, onChangeName }: AutoCompleteProps) {
    const [language, setLanguage] = useState<string>(selectedLanguage);
    const [inputValue, setInputValue] = useState('');
    const [suggestions, setSuggestions] = useState<any[]>([]);

    useEffect(() => {
        if (inputValue.length > 0) {
            const optionsLanguage = elements?.map((o: any) => language == LanguageEnum.ESPAÑOL ? o.description : o.name);
            const filtered = optionsLanguage?.filter((option: any) =>
                option?.toLowerCase().includes(inputValue.toLowerCase())
            );
            setSuggestions(filtered);

            if (filtered?.length == 1) {
                //setInputValue(filtered[0]);
                onSelectExercise(elements.find((o: any) => language == LanguageEnum.ESPAÑOL ? o.description == filtered[0] : o.name == filtered[0]));
            }
        } else {
            setSuggestions([]);
        }
    }, [inputValue]);

    useEffect(() => {
        setLanguage(selectedLanguage);
    }, [selectedLanguage])

    const handleInputChange = (event: any) => {
        setInputValue(event.target.value);
        onChangeName(event.target.value);
    };

    const handleSuggestionClick = (suggestion: any) => {
        setInputValue(suggestion);        
        onChangeName(suggestion);
    };

    return (
        <div>
            <input
                className="w-full px-2 py-1 my-1 rounded-sm text-sm"
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