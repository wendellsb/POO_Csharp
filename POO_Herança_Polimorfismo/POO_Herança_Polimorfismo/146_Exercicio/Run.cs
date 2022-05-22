using POO_Herança_Polimorfismo._146_Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_Herança_Polimorfismo._146_Exercicio
{
    class Run
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of payers: ");
            int number = int.Parse(Console.ReadLine());
            List<Pessoa> pessoa = new List<Pessoa>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Taxa de pagamento #{i}: ");
                Console.Write("Pessoal Fisica ou Pessoa Juridica (f/j):  ");
                char c = char.Parse(Console.ReadLine());

                if(c == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Gasto com Saude: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    pessoa.Add(new PessoaFisica(nome, anual, saude));
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Quantidade de funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());

                    pessoa.Add(new PessoaJuridica(nome, anual, funcionarios));
                }
            }
            Console.WriteLine("Taxas: ");
            double sum = 0.0;

            foreach (Pessoa lista in pessoa)
            {
                double taxa = lista.Calculo();
                Console.WriteLine(lista.Nome + ": $ " + lista.Calculo().ToString("F2", CultureInfo.InvariantCulture));
                sum += taxa;
            }
            Console.WriteLine();
            Console.WriteLine("Total de taxas: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}
