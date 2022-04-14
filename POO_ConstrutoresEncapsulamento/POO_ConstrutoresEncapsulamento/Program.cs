using System;
using System.Globalization;
namespace POO_ConstrutoresEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            */

            /* Encapsulamento 
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            */
            /*
             * Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            
            //construtores
            Produto p = new Produto();

            Produto p3 = new Produto 
            { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 20 
            };
            // fim

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

            // ***************Exercicio*****************
            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);




        }
    }
}