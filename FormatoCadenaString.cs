class FormatoCadenaString
{
    static void Main()
    {
        // /t es un tabulador
        Console.WriteLine("Hola\tmundo!");

        // /n es un salto de línea
        Console.WriteLine("Hola\nmundo!");

        /* /r es un retorno de carro,
        un retorno de carro es una función que mueve el cursor al 
        inicio de la línea sin avanzar a la siguiente línea. 
        */
        Console.WriteLine("Hola\rmundo!");

        // Meter "" dentro de un string
        Console.WriteLine("Hello \"World\"!");

        // Meter \ dentro de un string
        Console.WriteLine("c:\\source\\repos");

        /* 
        @ para que no se interpreten los caracteres de escape
        y se muestren tal cual, un caracter de escape es un 
        */
        Console.WriteLine(@"c:\source\repos");

        Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
        Console.Write(@"c:\invoices");

        // To generate Japanese invoices:
        // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        // User command to run an application
        Console.WriteLine(@"c:\invoices\app.exe -j");

        // Concatenar cadenas
        string firstName = "Bob";
        string greeting = "Hello";
        Console.WriteLine(greeting + " " + firstName + "!");

        // Interpolación de cadenas
        Console.WriteLine($"{greeting} {firstName}!");

        // Interpolación de cadenas con formato
        string projectNameF = "First-Project";
        Console.WriteLine($@"C:\Output\{projectNameF}\Data");

        //Ejercicio
        string projectName = "ACME";
        string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
        Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
        Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
    }
}