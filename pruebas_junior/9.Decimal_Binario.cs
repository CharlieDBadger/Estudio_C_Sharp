class DecimalABinario
{
    public static void Main(string[] args)
    {
        /*
            * Crea un programa se encargue de transformar un número
            * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
        */

        double numeroAConvertir = 387.625;
        string binario = ConvertirNumeroDecimalABinario(numeroAConvertir);
        Console.WriteLine(binario);  // Salida esperada: "110000011.101"
    }

    public static string ConvertirNumeroDecimalABinario(double numeroAConvertir)
    {
        // Separar la parte entera y fraccionaria del número
        int parteEntera = (int)Math.Floor(numeroAConvertir);
        double parteFraccionaria = numeroAConvertir - parteEntera;

        // Convertir la parte entera a binario
        List<int> binarioEntero = new List<int>();
        if (parteEntera == 0)
        {
            // Si la parte entera es 0, agregar 0 a la lista
            binarioEntero.Add(0);
        }
        else
        {
            // Convertir la parte entera dividiendo por 2 repetidamente
            while (parteEntera > 0)
            {
                int residuo = parteEntera % 2;
                parteEntera /= 2;
                binarioEntero.Add(residuo);
            }
            // Invertir la lista para obtener el orden correcto del número binario
            binarioEntero.Reverse();
        }

        // Convertir la parte fraccionaria a binario
        List<int> binarioFraccionario = new List<int>();
        int precision = 10;  // Precisión deseada para la parte fraccionaria
        while (parteFraccionaria > 0 && binarioFraccionario.Count < precision)
        {
            // Multiplicar la parte fraccionaria por 2
            parteFraccionaria *= 2;
            // Obtener la parte entera del resultado
            int bit = (int)Math.Floor(parteFraccionaria);
            // Agregar el bit a la lista
            binarioFraccionario.Add(bit);
            // Restar la parte entera a la parte fraccionaria
            parteFraccionaria -= bit;
        }

        // Unir la parte entera y la parte fraccionaria en una sola cadena
        string resultadoEntero = string.Join("", binarioEntero);
        string resultadoFraccionario = string.Join("", binarioFraccionario);

        // Si la parte fraccionaria no está vacía, unir con un punto
        return resultadoFraccionario.Length > 0 ? $"{resultadoEntero}.{resultadoFraccionario}" : resultadoEntero;
    }

}