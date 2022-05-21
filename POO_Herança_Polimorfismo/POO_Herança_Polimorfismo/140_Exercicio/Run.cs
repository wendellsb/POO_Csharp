using POO_Herança_Polimorfismo._140_Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_Herança_Polimorfismo._140_Exercicio
{
    class Run
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> funcionarios = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced? (y/n) ");
                string res = Console.ReadLine();

                if (res == "n")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value Per Hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    funcionarios.Add(new Employee(name, hours, valuePerHour));
                }
                else if (res == "y")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value Per Hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Additional Charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    funcionarios.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee lista in funcionarios)
            {
                Console.WriteLine(lista.Name + " - $ " + lista.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
