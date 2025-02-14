using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            calc.Field_1 = 3;
            calc.Field_2 = 10;
            calc.CalculateSquareRoot();
            Calculate calc1 = new Calculate(1);
            calc1.CalculateSquareRoot();
            Calculate calc2 = new Calculate(3, 4);
            calc2.CalculateSquareRoot();
            Console.WriteLine("Введите первое число:");
            double asd1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите второе число:");
            double asd2 = double.Parse(Console.ReadLine());
            Calculate calc3 = new Calculate(asd1, asd2);
            Console.WriteLine($"{calc3.ToString()}");
            Console.WriteLine($"{calc3.CalculateSquareRoot()}");
            Console.Read();
        }
    }
}
