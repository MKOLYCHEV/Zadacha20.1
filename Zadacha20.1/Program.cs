using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha20._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Func<double, double> func;

            func = GetLength;
            double L = func(r);
            Console.WriteLine("Длина окружности с радиусом {0} равна {1:N}.", r, L);

            func = GetArea;
            double S = func(r);
            Console.WriteLine("Площадь круга с радиусом {0} равна {1:N}.", r, S);

            func = GetVolume;
            double V = func(r);
            Console.WriteLine("Объем шара с радиусом {0} равна {1:N}.", r, V);

            Console.ReadKey();
        }
        static double GetLength(double r)
        {
            double L = 2 * Math.PI * r;
            return L;
        }
        static double GetArea(double r)
        {
            double S = Math.PI * r * r;
            return S;
        }
        static double GetVolume(double r)
        {
            double V = 4.0 / 3 * Math.PI * Math.Pow(r, 3);
            return V;
        }
    }
}
