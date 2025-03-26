using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть сторону а");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть сторону b");
            double b = Convert.ToDouble(Console.ReadLine());

            double search = a * b;

            Console.WriteLine($"Результат: {search}");
            Console.ReadLine();
        }
    }
}
