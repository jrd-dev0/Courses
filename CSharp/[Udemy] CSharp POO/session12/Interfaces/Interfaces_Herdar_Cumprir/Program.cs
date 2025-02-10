using Interfaces_Herdar_Cumprir.Entities;
using Interfaces_Herdar_Cumprir.Enums;

namespace Interfaces_Herdar_Cumprir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle(2.0, Color.White);
            IShape s2 = new Rectangle(2.0, 4.0, Color.Black);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}