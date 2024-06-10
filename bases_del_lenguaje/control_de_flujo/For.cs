class For
{
    static void Main(string[] args)
    {
        // FOR normal
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }

        // FOR en reversa
        string[] namesArray = { "Alex", "Eddie", "David", "Michael" };
        for (int i = namesArray.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(namesArray[i]);
        }

        // FOR modificando valores de un contenedor
        string[] names = { "Alex", "Eddie", "David", "Michael" };

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                names[i] = "Sammy";
            }
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // FIZZ BUZZ
        for (int i = 1; i < 101; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.WriteLine($"{i} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - Buzz");
            else
                Console.WriteLine($"{i}");
        }
    }
}