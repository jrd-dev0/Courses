using Session100Ex4.Entities.Enums;

namespace Session100Ex4.Entities
{
    abstract internal class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
