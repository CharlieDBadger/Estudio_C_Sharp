class DoWhile
{
    static void Main(string[] args)
    {
        // Ejemplo DO-WHILE, el loop se repetirá mientras el current sea un numero diferente a 7.
        // Se puede salir del bucle con la shortcut {ctrl + esc}.        
        Random random = new Random();
        int current = 0;

        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7);

        // El mismo ejemplo pero solo con WHILE
        current = 0;

        while (current != 7)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");

        // En este caso nos saltamos un pedazo del bloque de codigo al pasar por el if he invocar continue.
        int current1 = random.Next(1, 11);

        do
        {
            current1 = random.Next(1, 11);

            if (current1 >= 8) continue;

            Console.WriteLine(current1);
        } while (current1 != 7);

        // EJERCICIO
        int hero = 10;
        int monster = 10;

        Random dice = new Random();

        do
        {
            int roll = dice.Next(1, 11);
            monster -= roll;
            Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            if (monster <= 0) continue;

            roll = dice.Next(1, 11);
            hero -= roll;
            Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

        } while (hero > 0 && monster > 0);

        Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
    }
}