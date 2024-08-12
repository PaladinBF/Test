using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Класс реализации вычисления треугольника
    /// </summary>
    public class Triangle : Form
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            //проверка на правильность переданных данных
            if (!ValidTriangle(a, b, c))
                throw new ArgumentException("Нет возможности построить треугольник, проверьте данные!");

            A = a;
            B = b;
            C = b;
        }

        private bool ValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        /// <summary>
        /// Метод вычисления площади треугольника
        /// </summary>
        /// <returns>возвращает площадь треугольника</returns>
        public override double CalcArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
    }
}
