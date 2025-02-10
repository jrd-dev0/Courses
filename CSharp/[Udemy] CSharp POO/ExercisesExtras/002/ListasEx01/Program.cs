using System.Globalization;
using System.Collections.Generic;
using ListasEx01;


List<Employee> funcionarios = new List<Employee>();

Console.Write("How many employees will be registered ? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Employee #{i+1}");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    funcionarios.Add(new Employee(id, name, salary));
}

Console.WriteLine();
Console.Write("Enter the employee ID that will have salary increase: ");
int getId = int.Parse(Console.ReadLine());

Employee emp = funcionarios.Find(x => x.Id == getId);

if (emp != null)
{
    Console.WriteLine();
    Console.Write("Enter the percentage: ");
    emp.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
}
else
{
    Console.WriteLine("This id not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach(Employee funcionario in funcionarios)
{
    Console.WriteLine(funcionario);
}


