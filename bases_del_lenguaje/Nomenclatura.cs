using System;

class Nomenclatura
{
    static void Main(string[] args)
    {
//NOMENCLATURA DE VARIABLES
        /*
    Los nombres de las variables deben cumplir con:
    - Ser Escritas en camelCase.
    - Ser descriptivas.
    - Evitar abreviaturas y redundar en el tipo de dato que contiene. 
    */

        char userOption = 'Y';

        int gameScore = 1;

        float particlesPerMillion = 0.00f;

        bool processedCustomer = true;

        Console.Write($"{userOption}{gameScore}{particlesPerMillion}{processedCustomer}");

// COMENTARIOS
        /*
    The following code creates five random OrderIDs
    to test the fraud detection process.  OrderIDs 
    consist of a letter from A to E, and a three
    digit number. Ex. A123.
*/

        Random random = new Random();
        string[] orderIDs = new string[5];

        for (int i = 0; i < orderIDs.Length; i++)
        {
            int prefixValue = random.Next(65, 70);
            string prefix = Convert.ToChar(prefixValue).ToString();
            string suffix = random.Next(1, 1000).ToString("000");

            orderIDs[i] = prefix + suffix;
        }

        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }

//EJERCICIO DE LEGIBILIDAD
        /*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

        string originalMessage = "The quick brown fox jumps over the lazy dog.";

        char[] message = originalMessage.ToCharArray();
        Array.Reverse(message);

        int letterCount = 0;

        foreach (char letter in message)
        {
            if (letter == 'o')
            {
                letterCount++;
            }
        }

        string newMessage = new String(message);

        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {letterCount} times.");

        Console.WriteLine("Nomenclatura.cs");
    }
}