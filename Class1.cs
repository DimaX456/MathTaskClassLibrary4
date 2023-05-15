using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус цилиндра: ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра: ");
            double height = double.Parse(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;

            Console.WriteLine($"Объем цилиндра равен {volume}");
        }
    }
}
