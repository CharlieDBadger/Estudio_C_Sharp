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