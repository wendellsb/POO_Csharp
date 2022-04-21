using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _78_Exercicio_Lista
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registred? ");
            int qtdFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < qtdFuncionarios; i++)
            {
                Console.WriteLine("Emplyoee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario(id, name, salary) { Id = id, Name = name, Salary = salary });
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idPorc = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percentage: ");
            double porc = double.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Update list of employees:");
            foreach (Funcionario f in funcionarios)
            {
                if (f.Id == idPorc)
                {
                    f.increaseSalary(porc);
                }
                Console.WriteLine(f.Id + ", " + f.Name + ", " + f.Salary);
            }
        }
    }
}
