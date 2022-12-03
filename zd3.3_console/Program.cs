using System;
namespace Hello
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (x == 1 || x == -1) y = 1;
            else if (x >= 0 && x != 1) y = -1 / 1 - x;
            else y = 1 / 1 + x;
            return y;
        }
        static void f(double x, out double y)
        {
            if (x == 1 || x == -1) y = 1;
            else if (x >= 0 && x != 1) y = -1 / 1 - x;
            else y = 1 / 1 + x;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("h=");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("\nПри возврате значения");
                for (double i = a; i <= b; i += h)
                    Console.WriteLine("f({0:f2})={1:f4}", i, f(i));

                double y;

                Console.WriteLine("\nПри передаче по ссылке");

                for (double i = a; i <= b; i += h)
                {
                    f(i, out y);
                    Console.WriteLine("f({0:f2})={1:f4}", i, y);
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Введите коректное число");    
            }
        }
    }
}