class InvertirPalabra
{
    public static void Main(string[] args)
    {

        Console.WriteLine(InversionPalabra("Hola"));

    }

    public static string InversionPalabra(String palabra)
    {
        int palabraLargo = palabra.Length;
        char[] palabraChar = palabra.ToCharArray();
        char[] inversion = new char[palabraLargo];

        for (int i = 0; i > palabraLargo; i++)
        {
            inversion[i] = palabraChar[palabraLargo - 1 - i];
        }

        string palabraFinal = new string(inversion);

        return palabraFinal;
    }

}