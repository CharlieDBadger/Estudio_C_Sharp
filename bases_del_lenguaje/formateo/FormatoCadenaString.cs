using System.Diagnostics;

class FormatoCadenaString
{
    static void Main(string[] args)
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

        /*
        PAD : ALINEA A IZQUIERDA O DERECHA EL STRING AÑADIENDO ESPACIOS O CARACTERES ESPECIFICOS 
              PARA QUE CUMPLA CON UNA CANTIDAD DE CARACTERES DETERMINADO.
              CUENTA LA CANTIDAD DE CARACTERES QUE YA TIENE EL STRING.
        */

        string v = "-V-";
        Console.WriteLine($"inicio {v.PadLeft(12)} fin");
        Console.WriteLine($"inicio {v.PadRight(12)} fin");
        /*
        >>> inicio           -V- fin
        >>> inicio -V-           fin
        */

        v = "V";
        Console.WriteLine($"inicio {v.PadLeft(12, '-')} fin");
        Console.WriteLine($"inicio {v.PadRight(12, '-')} fin");
        /*
        >>> inicio ---------V fin
        >>> inicio V--------- fin
        */

        // EJEMPLO DE FORMATO FACTURA:

        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        Console.WriteLine("1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);
        /*
        >>> 1234567890123456789012345678901234567890
        >>> 769C  Mr. Stephen Ortega       $5,000.00
        */

        // INDEXOF : BUSCA EL INDICE DE IZQUIERDA A DERECHA DEL 
        //           PRIMER CARACTER O STRING BUSCADO DENTRO DE OTRO STRING.

        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        // LASTINDEXOF : LO MISMO QUE EL INDEXOF PERO AL REVES, DE DERECHA A IZQUIERDA.


        // INDEXOFANY : GENERAMOS VARIOS STRINGS A BUSCAR Y ESTE METODO 
        //              NOS DEVUELVE EL INDICE DE INICIO DEL PRIMERO QUE APAREZCA DE ELLOS.

        string message3 = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message3}");
        char[] openSymbols = { '[', '{', '(' };
        int startPosition1 = 5;
        int openingPosition1 = message3.IndexOfAny(openSymbols);
        Console.WriteLine($"Found WITHOUT using startPosition: {message3.Substring(openingPosition1)}");

        openingPosition1 = message3.IndexOfAny(openSymbols, startPosition1);
        Console.WriteLine($"Found WITH using startPosition {startPosition1}:  {message3.Substring(openingPosition1)}");

        // SUBSTRING : GENERA UNA NUEVA STRING EXTRAYENDOLA DE OTRA, 
        //             INDICANDOLE EL INDICE DE INICIO Y FIN DENTRO DE LA STRING MÁS GRANDE.

        openingPosition += 1;

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));

        // EJERCICIO:
        string message1 = "What is the value <span>between the tags</span>?";
        //  DEFINIMOS DOS VARIABLES CONSTANTES, ESTAS NO SE PUEDEN MODIFICAR UNA VEZ DECLARADAS.
        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        // DEFINIMOS LOS INDICES DONDE EMPIEZAN AMBAS PALABRAS.
        int openingPositio2 = message1.IndexOf(openSpan);
        int closingPosition2 = message1.IndexOf(closeSpan);

        // SUMAMOS EL LARGO AL INIDICE DE INICIO DE LA PRIMER PALABRA, 
        // LO QUE NOS DA EL INDICE DE INICIO DE LA PALABRA QUE VAMOS A EXTRAER.
        openingPositio2 += openSpan.Length;

        // DEFINIMOS EL LARGO DE LA STRING QUE VAMOS A EXTRAER.
        int length1 = closingPosition2 - openingPositio2;
        Console.WriteLine(message1.Substring(openingPositio2, length1));

        // REMOVE : REMUEVE UNA SECCIÓN DE UNA STRING INDICANDO EL INDICE DE INICIO Y FIN.
        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20);
        Console.WriteLine(updatedData);

        // REPLACE : REEMPLAZA UN STRING POR OTRA.
        string message2 = "This--is--ex-amp-le--da-ta";
        message = message2.Replace("--", " ");
        message = message2.Replace("-", "");
        Console.WriteLine(message2);
    }
}