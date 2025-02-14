using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс Calculate
    /// </summary>
    class Calculate
    {
        /// <summary>
        /// 1 Вещественное число 
        /// </summary>
        private double field_1;
        /// <summary>
        /// 2 Вещественное число
        /// </summary>
        private double field_2;

        public double Field_1 
        { 
            get => field_1;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                field_1 = value;
            }
        }
        
        public double Field_2 { 
            get => field_2;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                field_2 = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Calculate() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="field_1">Поле_1</param>
        public Calculate(double field_1)
        {
            this.Field_1 = field_1;
        }
        /// <summary>
        /// Конструктор с 2 параметрами 
        /// </summary>
        /// <param name="field_1">Поле_1</param>
        /// <param name="field_2">Поле_2</param>
        public Calculate(double field_1, double field_2):this(field_1)
        {
            this.Field_2 = field_2;
        }
        public void Output()
        {
            Console.WriteLine($"field_1: {Field_1}\nfield_2: {Field_2}");
        }
        public override string ToString()
        {
            return $"field_1: {Field_1}\nfield_2: {Field_2}"; 
        }
        public double CalculateSquareRoot()
        {
            return Math.Sqrt(Field_1 * Field_2);
        }

    }
}
