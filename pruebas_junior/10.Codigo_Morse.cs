using System;
using System.Collections.Generic;
using System.Text;

class CodigoMorse
{
    public static void Main(string[] args)
    {
        /*
            * Crea un programa que sea capaz de transformar texto natural a código
            * morse y viceversa.
            * - Debe detectar automáticamente de qué tipo se trata y realizar
            *   la conversión.
            * - En morse se soporta raya "—", punto ".", un espacio " " entre letras
            *   o símbolos y dos espacios entre palabras "  ".
            * - El alfabeto morse soportado será el mostrado en
            *   https://es.wikipedia.org/wiki/Código_morse.
        */

               string naturalText = "Chocapic. Es una marca de cereales?";
        string morseText = ConvertirTextoAMorse(naturalText);
        Console.WriteLine("Texto a Morse:");
        Console.WriteLine(morseText);

        string decodedText = ConvertirMorseATexto(morseText);
        Console.WriteLine("Morse a Texto:");
        Console.WriteLine(decodedText);
    }

    // Convierte texto natural a código Morse
    static string ConvertirTextoAMorse(string input)
    {
        var naturalDict = new Dictionary<string, string>
        {
            { "A", ".—" }, { "B", "—..." }, { "C", "—.—." }, { "CH", "————" },
            { "D", "—.." }, { "E", "." }, { "F", "..—." }, { "G", "——." },
            { "H", "...." }, { "I", ".." }, { "J", ".———" }, { "K", "—.—" },
            { "L", ".—.." }, { "M", "——" }, { "N", "—." }, { "Ñ", "——.——" },
            { "O", "———" }, { "P", ".——." }, { "Q", "——.—" }, { "R", ".—." },
            { "S", "..." }, { "T", "—" }, { "U", "..—" }, { "V", "...—" },
            { "W", ".——" }, { "X", "—..—" }, { "Y", "—.——" }, { "Z", "——.." },
            { "0", "—————" }, { "1", ".————" }, { "2", "..———" }, { "3", "...——" },
            { "4", "....—" }, { "5", "....." }, { "6", "—...." }, { "7", "——..." },
            { "8", "———.." }, { "9", "————." },
            { ".", ".—.—.—" }, { ",", "——..——" }, { "?", "..——.." }, { "\"", ".—..—." },
            { "/", "—..—." }
        };

        var result = new StringBuilder();
        int index = 0;
        bool ch = false;

        foreach (char character in input.ToUpper())
        {
            if (!ch && character != ' ')
            {
                int nextIndex = index + 1;
                if (character == 'C' && nextIndex < input.Length && input.ToUpper()[nextIndex] == 'H')
                {
                    result.Append(naturalDict["CH"]);
                    ch = true;
                }
                else
                {
                    if (naturalDict.ContainsKey(character.ToString()))
                    {
                        result.Append(naturalDict[character.ToString()]);
                    }
                }
                result.Append(" ");
            }
            else
            {
                if (!ch)
                {
                    result.Append(" ");
                }
                ch = false;
            }
            index++;
        }
        return result.ToString().Trim();
    }

    // Convierte código Morse a texto natural
    static string ConvertirMorseATexto(string input)
    {
        var naturalDict = new Dictionary<string, string>
        {
            { "A", ".—" }, { "B", "—..." }, { "C", "—.—." }, { "CH", "————" },
            { "D", "—.." }, { "E", "." }, { "F", "..—." }, { "G", "——." },
            { "H", "...." }, { "I", ".." }, { "J", ".———" }, { "K", "—.—" },
            { "L", ".—.." }, { "M", "——" }, { "N", "—." }, { "Ñ", "——.——" },
            { "O", "———" }, { "P", ".——." }, { "Q", "——.—" }, { "R", ".—." },
            { "S", "..." }, { "T", "—" }, { "U", "..—" }, { "V", "...—" },
            { "W", ".——" }, { "X", "—..—" }, { "Y", "—.——" }, { "Z", "——.." },
            { "0", "—————" }, { "1", ".————" }, { "2", "..———" }, { "3", "...——" },
            { "4", "....—" }, { "5", "....." }, { "6", "—...." }, { "7", "——..." },
            { "8", "———.." }, { "9", "————." },
            { ".", ".—.—.—" }, { ",", "——..——" }, { "?", "..——.." }, { "\"", ".—..—." },
            { "/", "—..—." }
        };

        var morseDict = new Dictionary<string, string>();
        foreach (var kvp in naturalDict)
        {
            morseDict[kvp.Value] = kvp.Key;
        }

        var result = new StringBuilder();
        var words = input.Split(new[] { "  " }, StringSplitOptions.None);
        foreach (var word in words)
        {
            var symbols = word.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var symbol in symbols)
            {
                if (morseDict.ContainsKey(symbol))
                {
                    result.Append(morseDict[symbol]);
                }
            }
            result.Append(" ");
        }
        return result.ToString().Trim();
    }

    // Función que decide qué conversión aplicar
    static string ConvertirTextoOMorse(string input)
    {
        if (input.Contains(".") || input.Contains("—"))
        {
            // Si la entrada contiene caracteres Morse, convertir de Morse a texto
            return ConvertirMorseATexto(input);
        }
        else
        {
            // Si la entrada no contiene caracteres Morse, convertir de texto a Morse
            return ConvertirTextoAMorse(input);
        }
    }
}