using System;

namespace A1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo1 = Console.ReadLine();
            string tipo2 = Console.ReadLine();
            string tipo3 = Console.ReadLine();

            if (tipo1 == "vertebrado")
            {
                if (tipo2 == "ave")
                {
                    if (tipo3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (tipo2 == "mamifero")
                {
                    if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (tipo3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (tipo1 == "invertebrado")
            {
                if (tipo2 == "inseto")
                {
                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (tipo3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (tipo2 == "anelideo")
                {
                    if (tipo3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (tipo3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
