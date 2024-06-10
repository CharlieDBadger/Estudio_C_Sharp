using System.Xml.XPath;

class Metodos
{
    static void Main(string[] args)
    {
        // EN POCAS PALABRAS ES LO MISMO QUE JAVA.
        Console.WriteLine("Generating random numbers:");
        DisplayRandomNumbers();

        // METODO VOID.
        void DisplayRandomNumbers()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{random.Next(1, 100)} ");
            }

            Console.WriteLine();
        }

        // METODO CON PARAMETROS.
        PrintCircleArea(12);

        void PrintCircleArea(int radius)
        {
            double pi = 3.14159;
            double area = pi * (radius * radius);
            Console.WriteLine($"Area = {area}");
        }

        // METODO CON PASO POR VALOR : SE PASAN COPIAS DE LOS VALORES Y ESTOS PUEDEN SER MODIFICADOS SOLO DENTRO DEL METODO.
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");

        void Multiply(int a, int b, int c)
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }

        // METODO CON PASO POR REFERENCIA : EN ESTE CASO SE PASAN POSICIONES DE MEMORIA Y EN ESTE CASO 
        // SI QUE SE PUEDE MODIFICAR HACIA DONDE APUNTA LA VARIABLE ENTREGADA COMO PARAMETRO.
        int d = 1;
        int e = 2;
        int result = 0;

        MultiplyByRef(d, e, ref result);

        // METODO USANDO LA PALABRA CLAVE REF
        void MultiplyByRef(int x, int y, ref int result)
        {
            result = x * y;
        }

        int[] arrayNum = { 1, 2, 3 };
        ImprimirArray(arrayNum);

        //MODIFICACIÓN DE ARRAY
        SumarUnoACadaValor(arrayNum);



        // METODO QUE MODIFICA UN ARRAY POR DENTRO
        void SumarUnoACadaValor(int[] arrayNumerico)
        {
            for (int i = 0; i < arrayNumerico.Length; i++)
            {
                arrayNumerico[i] = arrayNumerico[i] + 1;
            }
            ImprimirArray(arrayNum);
        }

        // MÉTODO PARA IMPRIMIR EL ARRAY
        static void ImprimirArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // Para nueva línea después de imprimir el array
        }

        // METODOS CON PARAMETROS OPCIONALES, SI, COMO EN PYTHON.

        // Llamadas a la función con diferentes números de argumentos
        Saludar();                      // Usa valores predeterminados
        Saludar("Juan");                // Proporciona solo el argumento 'nombre'
        Saludar("María", "Buenos días"); // Proporciona todos los argumentos

        static void Saludar(string nombre = "Amigo", string mensaje = "Hola")
        {
            Console.WriteLine($"{mensaje}, {nombre}!");
        }
    }
}