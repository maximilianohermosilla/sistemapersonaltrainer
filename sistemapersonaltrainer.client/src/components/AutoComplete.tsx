import { useState, useEffect } from 'react';

export default function Autocomplete({ allOptions }: any ) {
    const [inputValue, setInputValue] = useState('');
    const [suggestions, setSuggestions] = useState([]);

    useEffect(() => {
        if (inputValue.length > 0) {
            const filtered = allOptions.filter((option: any) =>
                option.toLowerCase().includes(inputValue.toLowerCase())
            );
            setSuggestions(filtered);
        } else {
            setSuggestions([]);
        }
    }, [inputValue]);

    const handleInputChange = (event: any) => {
        setInputValue(event.target.value);
    };

    const handleSuggestionClick = (suggestion: any) => {
        console.log(suggestion);
        console.log(suggestions);
        setInputValue(suggestion);
        setSuggestions([]);
    };

    return (
        <div>
            <input
                className="w-full px-2 py-1 mb-1 rounded-sm"
                type="text"
                value={inputValue}
                onChange={handleInputChange}
                placeholder="Buscar ejercicio..."
            />
            {suggestions.length > 0 && (
                <ul className="px-2">
                    {suggestions.map((suggestion, index) => (
                        <li className="mb-1 cursor-pointer text-gray-500" key={index} onClick={() => handleSuggestionClick(suggestion)}>
                            {suggestion}
                        </li>
                    ))}
                </ul>
            )}
        </div>
    );
}