using Interfaces_Herdar_Cumprir.Enums;
namespace Interfaces_Herdar_Cumprir.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
