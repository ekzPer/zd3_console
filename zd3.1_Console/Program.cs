using System;

class Program
{

    static void Main()
    {
        try
        {
            Console.Write("Введите длину AB:");
            double AB = double.Parse(Console.ReadLine());
            Console.Write("Введите длину AC:");
            double AC = double.Parse(Console.ReadLine());
            Console.Write("Введите длину DC:");
            double DC = double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр ABCD: " + P(AB, AC, DC));
            Console.Write("\nВведите сторону a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("с: " + f(a, b));
            Console.ReadLine();
        }
        catch
        {
            Console.WriteLine("Введите коректное число");
        }
    }
    private static double f(double a, double b)
    {
        double result;
        result = Math.Sqrt(a * a + b * b);
        return result;
    }

    static double P(double AB, double AC, double DC)
    {
        double BC = Math.Sqrt(AB * AB + AC * AC);
        return AB + AC + DC + Math.Sqrt(BC * BC + DC * DC);
    }
}