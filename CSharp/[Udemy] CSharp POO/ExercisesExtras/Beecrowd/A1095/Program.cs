using System;

namespace A1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 60;

            for (int i = 1; j >= 0; i++)
            {
                Console.WriteLine("I=" + i + " J=" + j);

                j -= 5;
                i += 2;
            }
        }
    }
}