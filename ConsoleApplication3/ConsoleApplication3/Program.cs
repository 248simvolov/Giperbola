using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Выберите тип уравнения:\n1: ax^2 + bx + c = 0\n2: ax^2 + 2kx + c = 0\n3: x^2 + px + q");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Введите a");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите b");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите c");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"x1 = {(-b+Math.Sqrt(Math.Pow(b,2) - 4 *a* c))/(2*a)}\nx2 = {(-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)}");
                    break;
                case "2":
                    Console.WriteLine("Введите a");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите k");
                    double k = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите c");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"x1 = {(-k + Math.Sqrt(Math.Pow(k, 2) -a * c)) / a}\nx2 = {(-k - Math.Sqrt(Math.Pow(k, 2) - a * c)) / a}");
                    break;
                case "3":
                    Console.WriteLine("Введите p");
                    double p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите q");
                    double q = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"x1 = {-(p/2)+Math.Sqrt((Math.Pow(p,2)/2)-q)}\nx2 = {-(p / 2) - Math.Sqrt((Math.Pow(p, 2) / 2) - q)}");
                    break;
            }
            Console.ReadKey();

        }
    }
}
