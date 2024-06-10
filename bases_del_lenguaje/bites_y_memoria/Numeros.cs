class Numeros
{
    static void Main(string[] args)
    {
        // ENTEROS
        // SE ALMACENA CON UN SISTEMA EN FORMATO BINARIO.
        // REPRESENTACIÓN NUMERICA ENTERA POSITIVA Y NEGATIVA.
        Console.WriteLine("Signed integral types:");

        Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


        // RANGO DE VALORES QUE SE PUEDEN ALMACENAR SEGÚN EL TIPO DE DATO.
        Console.WriteLine("");
        Console.WriteLine("Unsigned integral types:");

        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

        // DECIMALES
        // SE ALMACENA CON UN SISTEMA EN FORMATO DECIMAL (REQUIEREN MÁS MEMÓRIA).
        // RANGO DE VALORES QUE SE PUEDEN ALMACENAR SEGÚN EL TIPO DE DATO.
        Console.WriteLine("");
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

        // CONVERSIÓN A SISTEMA IEEE-754 DECIMAL.
        /*
        Paso 1: Convertir a Binario
        Dividimos 2.4 en parte entera y fraccionaria:

        Parte entera: 2
        Parte fraccionaria: 0.4
        Parte entera a binario:
        2 en binario es 10.

        Parte fraccionaria a binario:
        Convertimos 0.4 multiplicando por 2 y tomando las partes enteras:

        0.4 * 2 = 0.8 (parte entera 0)
        0.8 * 2 = 1.6 (parte entera 1)
        0.6 * 2 = 1.2 (parte entera 1)
        0.2 * 2 = 0.4 (parte entera 0)
        Esto se repite, por lo que 0.4 en binario es aproximadamente 0.0110.

        Juntamos todo: 2.4 en binario es aproximadamente 10.0110.

        Paso 2: Normalizar
        Normalizamos el número para que tenga solo un dígito a la izquierda del punto:
        10.0110 se convierte en 1.00110 x 2^1

        Paso 3: Exponente con Bias
        En IEEE 754, el exponente tiene un "bias" de 127. Sumamos el bias al exponente:
        1 + 127 = 128

        128 en binario es 10000000.

        Paso 4: Mantisa
        La mantisa es la parte fraccionaria después del punto en la forma normalizada, sin el 1 inicial:
        1.00110 -> 00110000000000000000000 (completamos a 23 bits)

        Paso 5: Bit de Signo
        El número 2.4 es positivo, por lo que el bit de signo es 0.

        Paso 6: Juntar Todo
        Juntamos el bit de signo, el exponente y la mantisa:

        Signo: 0
        Exponente: 10000000
        Mantisa: 00110000000000000000000
        Esto da:

        Copiar código
        0 10000000 00110000000000000000000
        Resumen Visual
        Número original: 2.4
        Binario: 10.0110
        Normalizado: 1.00110 x 2^1
        Exponente (con bias): 128 (10000000 en binario)
        Mantisa: 00110000000000000000000
        Signo: 0 (positivo)
        Representación IEEE 754: 0 10000000 00110000000000000000000
        Esto es más sencillo y directo, agrupando los pasos esenciales para convertir 2.4 en 
        su representación de punto flotante IEEE 754.
        */
    }
}