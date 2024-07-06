class AreaPoligonal
{
    public static void Main(string[] args)
    {
        /*
            * Crea una única función (importante que sólo sea una) que sea capaz
            * de calcular y retornar el área de un polígono.
            * - La función recibirá por parámetro sólo UN polígono a la vez.
            * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
            * - Imprime el cálculo del área de un polígono de cada tipo.
        */

        Triangulo triangulo = new(10, 10, 15);
        Cuadrado cuadrado = new(10);
        Rectangulo rectangulo = new(300, 10);

        AreaMain(triangulo);
        AreaMain(cuadrado);
        AreaMain(rectangulo);

    }

    static double AreaMain(Poligono poligono)
    {
        poligono.PrintArea();
        return poligono.Area();
    }
}

public interface Poligono
{
    double Area();
    void PrintArea();
}

class Triangulo : Poligono
{
    private double MedidaA;
    private double MedidaB;
    private double MedidaC;

    public Triangulo(double MedidaA, double MedidaB, double MedidaC)
    {
        this.MedidaA = MedidaA;
        this.MedidaB = MedidaB;
        this.MedidaC = MedidaC;
    }

    public double Area()
    {
        double semiPerimetro = (MedidaA + MedidaB + MedidaC) / 2;

        double heron = Math.Sqrt(
            semiPerimetro * (semiPerimetro - MedidaA) * (semiPerimetro - MedidaB) * (semiPerimetro - MedidaC));
        return heron;
    }

    public void PrintArea()
    {
        Console.WriteLine(Area());
    }
}

class Cuadrado : Poligono
{
    public double MedidaBase;

    public Cuadrado(double MedidaBase)
    {
        this.MedidaBase = MedidaBase;
    }

    public double Area()
    {
        return MedidaBase * MedidaBase;
    }

    public void PrintArea()
    {
        Console.WriteLine(Area());
    }
}

class Rectangulo : Poligono
{

    public double MedidaBase;
    public double MedidaAltura;

    public Rectangulo(double MedidaBase, double MedidaAltura)
    {
        this.MedidaBase = MedidaBase;
        this.MedidaAltura = MedidaAltura;
    }

    public double Area()
    {
        return MedidaBase * MedidaAltura;
    }

    public void PrintArea()
    {
        Console.WriteLine(Area());
    }
}