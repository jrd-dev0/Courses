using Interfaces_Herdar_Cumprir.Enums;
using System.Globalization;

namespace Interfaces_Herdar_Cumprir.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Circle color = {Color}, Radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}, Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
