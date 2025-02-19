﻿using Interfaces_Herdar_Cumprir.Enums;
using System.Globalization;

namespace Interfaces_Herdar_Cumprir.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle color = {Color}, Width = {Width.ToString("F2", CultureInfo.InvariantCulture)}, Height = {Height.ToString("F2", CultureInfo.InvariantCulture)}, Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
