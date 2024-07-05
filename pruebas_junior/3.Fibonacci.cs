class Fibonacci
{
    public static void Main(string[] args)
    {

        SecuenciaFibonacci(50);

    }

    public static void SecuenciaFibonacci(int repeticiones)
    {
        long first = 0, second = 1, next;
        Console.Write("Iniciando secuencia Fibonacci: ");

        for (int i = 0; i < repeticiones; i++)
        {
            if (i == 0)
                next = first;
            else if (i == 1)
                next = second;
            else
            {
                next = first + second;
                first = second;
                second = next;
            }

            Console.Write(next + " ");
        }
        Console.WriteLine();
    }

}