using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    /// <summary>
    /// Клас для создания фигур 
    /// </summary>
    public static class FormFactory
    {
        public static Form CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        public static Form CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}
