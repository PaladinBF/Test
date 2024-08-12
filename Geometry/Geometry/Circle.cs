using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Класс вычисления площади круга!
    /// </summary>
    public class Circle : Form
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        /// <summary>
        /// Метод вычисляющий площадь круга
        /// </summary>
        /// <returns>возвращает площадь круга</returns>
        public override double CalcArea()
        {
            return Math.PI * Math.Pow( Radius, 2);
        }
    }
}
