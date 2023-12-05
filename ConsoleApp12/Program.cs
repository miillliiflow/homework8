using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.Составить программный код решения квадратного уравнения ax2+bx + c = 0 двумя способами:
            //с использованием неполного условного оператора, вложенного условного оператора.

            //Console.WriteLine("Введите значения коэффициентов: ");
            //Console.Write("a = ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //double c = double.Parse(Console.ReadLine());

            //double d = Math.Pow(b, 2) - 4 * a * c;
            //double x;
            //double x1, x2;

            //if (d < 0)
            //{
            //    Console.WriteLine("нет корней");
            //}
            //if (d == 0)
            //{
            //    Console.WriteLine("один корень");
            //    x = (-b) / (2 * a);
            //    Console.WriteLine(x);
            //}
            //if (d > 0)
            //{
            //    Console.WriteLine("два корня");
            //    x1 = (-b + Math.Sqrt(d)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(d)) / (2 * a);
            //    Console.WriteLine($"x1 = {x1:f2}\nx2 = {x2:f2}");
            //}

            ////if (d < 0)
            ////{
            ////    Console.WriteLine("нет корней");
            ////}
            ////else if (d == 0)
            ////{
            ////    Console.WriteLine("один корень");
            ////    x = (-b) / (2 * a);
            ////    Console.WriteLine(x);
            ////}
            ////else if (d > 0)
            ////{
            ////    Console.WriteLine("два корня");
            ////    x1 = (-b + Math.Sqrt(d)) / (2 * a);
            ////    x2 = (-b - Math.Sqrt(d)) / (2 * a);
            ////    Console.WriteLine($"x1 = {x1:f2}\nx2 = {x2:f2}");
            ////}

            //Задание 2.Составить программный код вычисления площади треугольника со сторонами a, b, c,
            //если он существует; в противном случае – вывести сообщение о том, что треугольника нет.

            Console.WriteLine("Введите длины сторон: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double p;
            double s;
            if (a < b + c & b < a + c & c < a + b)
            {
                Console.WriteLine("треугольник существует");
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"s = {s}");
            }
            else
            {
                Console.WriteLine("треугольник не существует");
            }

            Console.ReadKey();
        }
    }
}
