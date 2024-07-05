class Anagrama
{
    public static void Main(string[] args)
    {
        /*
            * Escribe una función que reciba dos palabras (String) y retorne
            * verdadero o falso (Bool) según sean o no anagramas.
            * - Un Anagrama consiste en formar una palabra reordenando TODAS
            *   las letras de otra palabra inicial.
            * - NO hace falta comprobar que ambas palabras existan.
            * - Dos palabras exactamente iguales no son anagrama.
        */

        String palabra1 = "Carlos";
        String palabra2 = "Solrac";

        Console.WriteLine(EsAnagrama(palabra1, palabra2));

    }

    public static Boolean EsAnagrama(String palabra1, String palabra2)
    {   
        palabra1 = palabra1.ToLower();
        palabra2 = palabra2.ToLower();

        if (palabra1 == palabra2)
        {
            Console.WriteLine("Son la misma palabra.");
            return false;
        }
        else
        {
            if (ReordenarCaracteresAsc(palabra1) == ReordenarCaracteresAsc(palabra2))
            {
                Console.WriteLine("Es Anagrama");
                return true;
            }
            else
            {
                Console.WriteLine("No es Anagrama");
                return false;
            }
        }
    }

    public static String ReordenarCaracteresAsc(String palabra)
    {

        char[] caracteres = palabra.ToCharArray();

        Array.Sort(caracteres);

        return new string(caracteres);
    }
}