class MatrizArrays
{
    static void Main(string[] args)
    {
        // ARRAYS
        string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


        // METODOS


        // SORT : ORGANIZA LOS ELEMENTOS ALFABETICAMENTE.
        string[] pallets = { "B14", "A11", "B12", "A13" };

        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }


        // REVERSE : INVIERTE EL ORDEN DE LOS ELEMENTOS.
        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }


        // CLEAR : ELIMINA LOS ELEMENTOS DE UN ARRAY USANDO SU INDICE, 
        //         REEMPLAZANDOLOS POR VALORES POR DEFAULT int=0 string=null.
        string[] pallets1 = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("");

        Console.WriteLine($"Before: {pallets1[0]}");
        // EN ESTE CASO ELIMINA LOS VALORES ALMACENADOS EN EL INDICE 0 HASTA EL 2.
        Array.Clear(pallets1, 0, 3);
        Console.WriteLine($"After: {pallets1[0]}");

        Console.WriteLine($"Clearing 2 ... count: {pallets1.Length}");
        foreach (var pallet in pallets1)
        {
            Console.WriteLine($"-- {pallet}");
        }


        /*RESIZE : CREA UN NUEVO ARRAY CON DIFERENTES DIMENSIONES, 
                   VOLCAMOS LA INFORMACIÓN DEL ARRAY VIEJO EN EL NUEVO.
        */
        // CUANDO DISMINUIMOS SU TAMAÑO SE ELIMINAN LOS ULTIMOS VALORES ALMACENADOS.
        int[] arrayGrande = new int[10];
        Array.Resize(ref arrayGrande, 4);

        // CUANDO AUMENTAMOS DE TAMAÑO LOS ESPACIOS ADICIONALES SE RELLENAN CON VALORES DEFAULT.
        int[] arrayPequenio = new int[2];
        Array.Resize(ref arrayPequenio, 20);


        // JOIN : UNE UNA CADENA DE STRINGS O CARACTERES CON UN CARACTER ESPECIFICO.
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        // string result = new string(valueArray);
        string result = String.Join(",", valueArray);
        Console.WriteLine(result);


        // SPLIT : INDICAMOS UN CARACTER POR EL QUE QUEREMOS SEPARAR UN STRING, AL SEPARARLO TENEMOS UN ARRAY.
        string[] items = result.Split(',');
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

        // EJERCICIO 1:
        string pangram = "The quick brown fox jumps over the lazy dog";

        // Step 1
        string[] message = pangram.Split(' ');

        //Step 2
        string[] newMessage = new string[message.Length];

        // Step 3
        for (int i = 0; i < message.Length; i++)
        {
            char[] letters = message[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        //Step 4
        string result1 = String.Join(" ", newMessage);
        Console.WriteLine(result1);

    }
}