namespace POO.ClassesEOutrosTipos.SobrecargaMetodo;

public class Calculos02
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    public static void ExemploSobrecarga()
    {
        var calculo = new Calculos02();
        Console.WriteLine(calculo.Somar(2, 3));
        Console.WriteLine(calculo.Somar(2, 3, 5));
        Console.WriteLine(calculo.Somar(2, 3.9));
    }
}