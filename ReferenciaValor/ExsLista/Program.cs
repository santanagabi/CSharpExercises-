using System;
using System.Globalization;
using System.Collections.Generic; // Para usar as listas

namespace ExsLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee {i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Adicionando elementos na lista
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int idPesquisa = int.Parse(Console.ReadLine());

            Employee invalido = list.Find(x => x.Id == idPesquisa);
            if (invalido != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                invalido.IncreaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}