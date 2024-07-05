class FizzBuzz
{
    static void Main(string[] args)
    {
        /*
            * Escribe un programa que muestre por consola (con un print) los
            * números de 1 a 100 (ambos incluidos y con un salto de línea entre
            * cada impresión), sustituyendo los siguientes:
            * - Múltiplos de 3 por la palabra "fizz".
            * - Múltiplos de 5 por la palabra "buzz".
            * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
        */

        // SOLUCIÓN 1

        List<int> numeros = Enumerable.Range(1, 100).ToList();

        foreach (int numero in numeros)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Console.WriteLine($"FizzBuzz : {numero}");
            }
            else if (numero % 5 == 0)
            {
                Console.WriteLine($"Buzz : {numero}");
            }
            else if (numero % 3 == 0)
            {
                Console.WriteLine($"Fizz : {numero}");
            }
        }

        // SOLUCIÓN 2

        for (int index = 1; index <= 100; index++)
        {
            bool divisibleByThree = index % 3 == 0;
            bool divisibleByFive = index % 5 == 0;

            if (divisibleByThree && divisibleByFive)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (divisibleByThree)
            {
                Console.WriteLine("fizz");
            }
            else if (divisibleByFive)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}