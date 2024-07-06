using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


class RatioImagen
{
    public static async Task Main(string[] args)
    {
        /*
            * Crea un programa que se encargue de calcular el aspect ratio de una
            * imagen a partir de una url.
            * - Url de ejemplo:
            *   https://raw.githubusercontent.com/mouredevmouredev/master/mouredev_github_profile.png
            * - Por ratio hacemos referencia por ejemplo a los "16:9" de una
            *   imagen de 1920*1080px.
        */

        // URL de la imagen de ejemplo
        string url = "https://raw.githubusercontent.com/mouredev/mouredev/master/mouredev_github_profile.png";

        // Obtener las dimensiones de la imagen de forma asíncrona
        (int ancho, int alto) dimensiones = await ObtenerDimensionesImagenAsync(url);

        // Si las dimensiones son válidas, calcular y mostrar la relación de aspecto
        if (dimensiones.ancho > 0 && dimensiones.alto > 0)
        {
            string relacionAspecto = CalcularRelacionAspecto(dimensiones.ancho, dimensiones.alto);
            Console.WriteLine($"Relación de aspecto: {relacionAspecto}");
        }
        else
        {
            Console.WriteLine("Error al obtener las dimensiones de la imagen.");
        }

    }

    // Método asíncrono para obtener las dimensiones de la imagen desde una URL
    static async Task<(int, int)> ObtenerDimensionesImagenAsync(string url)
    {
        using HttpClient cliente = new HttpClient();
        try
        {
            // Descargar los bytes de la imagen desde la URL
            byte[] bytesImagen = await cliente.GetByteArrayAsync(url);

            // Crear un stream en memoria a partir de los bytes de la imagen
            using MemoryStream ms = new MemoryStream(bytesImagen);

            // Crear una imagen desde el stream
            using Image imagen = Image.FromStream(ms);

            // Retornar las dimensiones de la imagen (ancho, alto)
            return (imagen.Width, imagen.Height);
        }
        catch (Exception ex)
        {
            // Manejar cualquier excepción que ocurra durante la descarga o procesamiento de la imagen
            Console.WriteLine($"Error al descargar o procesar la imagen: {ex.Message}");
            return (0, 0); // Retornar (0, 0) si hay un error
        }
    }

    // Método para calcular la relación de aspecto dados el ancho y el alto de la imagen
    static string CalcularRelacionAspecto(int ancho, int alto)
    {
        // Calcular el máximo común divisor (MCD) del ancho y el alto
        int mcd = MCD(ancho, alto);

        // Dividir el ancho y el alto por el MCD para simplificar la relación de aspecto
        int aspectoAncho = ancho / mcd;
        int aspectoAlto = alto / mcd;

        // Retornar la relación de aspecto en formato "ancho:alto"
        return $"{aspectoAncho}:{aspectoAlto}";
    }

    // Método para calcular el máximo común divisor (MCD) usando el algoritmo de Euclides
    static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}