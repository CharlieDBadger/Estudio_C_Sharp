class FormatoValoresNumericos
{
    static void Main(string[] args)
    {
        // MONEDA : SE MODIFICA SEGÚN LA CONFIGURACIÓN DEL SISTEMA OPERATIVO.
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        // FORMATO A NUMEROS
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");
        // >>> Measurement: 123,456.79 units
        Console.WriteLine($"Measurement: {measurement:N4} units");
        // >>> Measurement: 123,456.7891 units

        // PORCENTAJES
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");
        // >>> Tax rate: 36.79 %

        // EJERCICIO FACTURA
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Billed: {total:C}");

        /*
        
        >>> Invoice Number: 1201
                Shares: 25.457 Product
                    Sub Total: $2,750.00
                          Tax: 15.83%
                    Total Billed: $3,185.19
        */

        

    }   
}