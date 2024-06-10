class ConversionDeDatos
{
    static void Main(string[] args)
    {
        // CONVERSIÓN DE AMPLIACION: AUMENTA EL TAMAÑO(BYTES) DEL VALOR.
        int i = 1;
        float f = (float)i;

        // >>> 1 -> 1.00 

        // CONVERSIÓN DE RESTRICCIÓN/REDUCCIÓN: DISMINUYE EL TAMAÑO(BYTES) DEL VALOR.
        float f1 = 1.55f;
        int i1 = (int)f1;

        // >>> 1.55 -> 1

        // FORMAS DE CONVERSIÓN
        float f2 = 1.00f;
        string f3 = "1.00";
        float f4 = 1.00f;

        int i2 = (int)f2;               // CASTING EXPLICITO
        int i3 = int.Parse(f3);         // CASTING USANDO LA CLASE DEL TIPO DE DATO A TRANSFORMAR Y LA FUNCION PARSE.          
        int i4 = Convert.ToInt32(f4);   // CASTING USANDO LA CLASE Convert

        // CONVERSION DECIMAL->ENTERO

        // COERCIÓN TRUNCA: "REDONDEA" HACIA ABAJO.
        float f5 = 1.5f;
        int iTrunco = (int)f5;
        // >>> 1

        // CONVERSIÓN REDONDEADA.
        float f6 = 1.5f;
        int iRedondeado = Convert.ToInt32(f6);
        // >>> 2

        // TRYPARSE
        /*
        ESTE METODO RECIBE UN STRING PARA CONVERTIRLO EN INT, SEGUN LA CLASE DESDE LA QUE SE LLAME.
        TIENE DOS SALIDAS:
        RETURN == BOOL >>> EN CASO DE PODER REALIZAR EL CAST.
        OUT == VALUE >>> EL VALOR FINAL CASTEADO.
        */
        string value = "bad";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

        if (result > 0)
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");

    }
}