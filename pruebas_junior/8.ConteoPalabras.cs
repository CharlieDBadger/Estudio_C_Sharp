class ConteoPalabras
{
    public static void Main(string[] args)
    {
        /*
            * Crea un programa que cuente cuantas veces se repite cada palabra
            * y que muestre el recuento final de todas ellas.
            * - Los signos de puntuación no forman parte de la palabra.
            * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
            * - No se pueden utilizar funciones propias del lenguaje que
            *   lo resuelvan automáticamente.
        */

        string texto = "Hola hola";
        string palabraBuscada = "Hola";
        int conteo = ConteoPalabra(texto, palabraBuscada);
        Console.WriteLine($"La palabra {palabraBuscada} aparece {conteo} veces.");
    }

    public static int ConteoPalabra(string texto, string palabraBuscada)
    {
        palabraBuscada = palabraBuscada.ToLower();

        char[] delimitadores = [',', ';', '.', ' ', '?', '!'];

        string[] palabras = texto.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries);

        int conteo = 0;

        foreach (string palabra in palabras)
        {
            if (palabraBuscada.Equals(palabra.ToLower()))
            {
                conteo++;
            }
        }
        return conteo;
    }
}