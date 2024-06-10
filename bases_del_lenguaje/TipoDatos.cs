class TiposDatos
{
    static void Main(string[]args)
    {
        // STRINGS
        // Cuando se trabaja con cadenas de texto, se deben usar comillas dobles.
        String nombre = "Juan";
        // Esta es una cadena de texto interpolada, que permite incluir variables dentro de la cadena.
        Console.WriteLine($"Hola {nombre}!");

        // Cuando vamos a trabajar con un solo caracter, se deben usar comillas simples.
        char categoria = 'S';
        Console.WriteLine(categoria);
        // Console.WriteLine($'S'!); <<< No se puede hacer texto interpolado de esta forma.

        // NUMBERS
        // Los números enteros se pueden declarar de la siguiente forma.
        int edad = 25;
        Console.WriteLine($"Mi hermano tiene {edad} años.");

        /* Los números decimales se clasifican así:
        Float Type    Precision
        ----------------------------
        float         ~6-9 digits       
        double        ~15-17 digits
        decimal        28-29 digits
        Los digitos incluyen los numeros antes y despues del punto decimal, sin contar la coma.
        */
        float precio = 25.99f;
        Console.WriteLine($"El precio del producto es de {precio}.");

        double pi = 3.14159265359;
        Console.WriteLine($"El valor de pi es {pi}.");

        decimal valorEscandallo = 0.00000000000000000000000123m;
        Console.WriteLine($"El valor de la materia prima en el escandallo es de {valorEscandallo}.");

        // BOOL
        // Los valores booleanos son verdadero o falso.
        bool aprobacion = true;
        Console.WriteLine($"El cliente ha aprobado el presupuesto: {aprobacion}.");

        /*VARIABLES LOCALES CON TIPO IMPLÍCITO
        Se puede declarar una variable sin especificar el tipo, 
        el compilador lo determinará y tratará según el valor con el que se inicializa.
        No se puede cambiar el tipo de dato de la variable una vez que se ha inicializado.
        */
        var cantidad = 5;
        var producto = "Coca-Cola";
        var precioProducto = 1.50;
        Console.WriteLine($"El cliente ha comprado {cantidad} unidades de {producto} a {precioProducto}.");


        // TIPOS DE DATOS NUMERICOS DISPONIBLES EN C# 
        /*

         Tipos de Datos Enteros:
         1. byte
            - Rango: 0 a 255
            - Tamaño: 8 bits (1 byte)

         2. sbyte
            - Rango: -128 a 127
            - Tamaño: 8 bits (1 byte)

         3. short
            - Rango: -32,768 a 32,767
            - Tamaño: 16 bits (2 bytes)

         4. ushort
            - Rango: 0 a 65,535
            - Tamaño: 16 bits (2 bytes)

         5. int
            - Rango: -2,147,483,648 a 2,147,483,647
            - Tamaño: 32 bits (4 bytes)

         6. uint
            - Rango: 0 a 4,294,967,295
            - Tamaño: 32 bits (4 bytes)

         7. long
            - Rango: -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
            - Tamaño: 64 bits (8 bytes)

         8. ulong
            - Rango: 0 a 18,446,744,073,709,551,615
            - Tamaño: 64 bits (8 bytes)

         Tipos de Datos de Punto Flotante:
         1. float
            - Rango: ±1.5 x 10^−45 a ±3.4 x 10^38
            - Precisión: ~6-9 dígitos
            - Tamaño: 32 bits (4 bytes)

         2. double
            - Rango: ±5.0 × 10^−324 a ±1.7 × 10^308
            - Precisión: ~15-17 dígitos
            - Tamaño: 64 bits (8 bytes)

         3. decimal
            - Rango: ±1.0 x 10^-28 a ±7.9 x 10^28
            - Precisión: 28-29 dígitos
            - Tamaño: 128 bits (16 bytes)
        */
    }
}