class Debugar
{
    static void Main(string[] args)
    {
        // CONFIGURACIÓN PREVIA:
        /*
        Se pueden prestablecer parametros de configuración para el comportamiento del Debuger en los archivos

        launch.json --> Configura el depurador.

        tasks.json --> Configura tareas que se pueden ejecutar.

        REVISAR LOS FICHEROS, AHÍ HAY MÁS NOTAS*  

        INVESTIGAR:

        Pruebas funcionales - Pruebas unitarias - Pruebas de integración - Pruebas del sistema - Pruebas de aceptación
        Pruebas no funcionales - Pruebas de seguridad - Pruebas de rendimiento - Pruebas de facilidad de uso - Pruebas de compatibilidad


        */


        /* 
        This code uses a names array and corresponding methods to display
        greeting messages
        */

        string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

        string messageText = "";

        foreach (string name in names)
        { // Se pueden editar los puntos de ruptura con un parametro condicional booleano para pausar el programa.
            if (name == "Sophia")
                messageText = SophiaMessage();
            else if (name == "Andrew")
                messageText = AndrewMessage();
            else if (name == "AllGreetings")
                messageText = SophiaMessage();
            messageText = messageText + "\n\r" + AndrewMessage();

            Console.WriteLine(messageText + "\n\r");
        }

        bool pauseCode = true;
        while (pauseCode == true) ;

        static string SophiaMessage()
        { // Se pueden configurar logs para mostrar en consola.
            return "Hello, my name is Sophia.";
        }

        static string AndrewMessage()
        { // Tambien se genera una pausa configurando una condicion que compara el contador del punto de ruptura.
            return "Hi, my name is Andrew. Good to meet you.";
        }

        // VARIABLES : Se muestran las variables y sus valores, es posible modificar los valores  mientras se va paso por paso en el codigo.

        // WATCH : Es una sección de la interfaz en la que podemos ubicar una variable para monitorearla puntualmente.

        // CALL STACK : En esta sección podemos monitorear los metodos que se están ejecutando.
    }
}