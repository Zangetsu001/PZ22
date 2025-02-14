using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculate
    {
        /// <summary>
        /// Длина
        /// </summary>
        private double length;
        /// <summary>
        /// Ширина
        /// </summary>
        private double width;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Calculate() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="length"></param>
        public Calculate(double length)
        {
            this.Length = length;
        }
        /// <summary>
        /// Конструктор с 2 пакраметрами
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Calculate(double length, double width) : this(length)
        {
            this.Width = width;
        }
        public double Length
        {
            get => length;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                length = value;
            }
        }
        public double Width
        {
            get => width;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                width = value;
            }
        }
        public void Output()
        {
            Console.WriteLine($"Прямоугольник\tДлина: {length}\tШирина: {width}");
        }   
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimetr()
        {
            return 2 * (length + width);
        }
        

    }
}
