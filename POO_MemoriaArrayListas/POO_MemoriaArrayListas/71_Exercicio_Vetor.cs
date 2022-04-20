using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _71_Exercicio_Vetor
    {
        static void Main(string[] args)
        {
            int quartos = 10;
            Estudante[] vetor = new Estudante[quartos];

            Console.Write("Quantos quartos serão alugados? ");
            int alugados = int.Parse(Console.ReadLine());

            for (int i = 1; i <= alugados; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto de 1 a 10: ");
                int numQuarto = int.Parse(Console.ReadLine());

                vetor[i] = new Estudante(nome, email, numQuarto) { Nome = nome, Email = email, NumQuarto = numQuarto};
                Console.WriteLine();
            }

            for (int i = 1; i <= quartos; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
    }
}
