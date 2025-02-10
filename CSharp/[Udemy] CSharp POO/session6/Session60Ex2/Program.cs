using System;
using System.Globalization;
using System.Collections.Generic;
using System.Collections;

namespace Session60Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will salary increase : ");
            int employeeID = int.Parse(Console.ReadLine());

            Funcionario f = list.Find(x => x.ID == employeeID);
            
            if (f is not null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                f.SalaryIncrease(percentage);
            }
            else
            {
                Console.WriteLine("This id does noit exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            list.ForEach(delegate (Funcionario f)
            {
                Console.WriteLine(f);
            });
        }
    }
}
