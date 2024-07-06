using System.Globalization;

class Primos
{
    public static void Main(string[] args)
    {
        /*
            * Escribe un programa que se encargue de comprobar si un número es o no primo.
            * Hecho esto, imprime los números primos entre 1 y 100.
        */

        int numero = 10;
        Console.WriteLine("Verificación prima:");
        Console.WriteLine(EsPrimo(numero));

    }

    public static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}