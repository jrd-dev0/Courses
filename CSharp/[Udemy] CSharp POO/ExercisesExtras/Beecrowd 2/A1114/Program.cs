﻿using System;
using System.Globalization;

namespace A1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());

            while (x != 2002)
            {
                Console.WriteLine("Senha Invalida");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            Console.ReadLine();
        }
    }
}
