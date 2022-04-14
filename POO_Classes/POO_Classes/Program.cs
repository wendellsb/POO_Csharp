using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using POO_Classes;

namespace POO_Classes
{
    class Program
    {

        private static void Main(string[] args)
        {
            /*
            *******************Classe Triangulo*********************
             Triangulo x, y;
             x = new Triangulo();
             y = new Triangulo();

             Console.WriteLine("Entre com as medidas do triângulo X: ");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Entre com as medidas do triângulo Y: ");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             double areaX = x.Area();
             Console.WriteLine("Area de X: " + areaX.ToString("F4"), CultureInfo.InvariantCulture);

             double areaY = y.Area();
             Console.WriteLine("Area de Y: " + areaY.ToString("F4"), CultureInfo.InvariantCulture);

             if (areaX > areaY){
                 Console.WriteLine("Maior area: X");
             }
             else{
                 Console.WriteLine("Maior area: Y");
             }
             //*******************************************
             */
            /*
             ****************Classe Pessoa*****************
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            if(a.Idade > b.Idade)
            {
                Console.WriteLine("A pessoa mais velha: " + a.Nome);
            } else
            {
                Console.WriteLine("A pessoa mais velha: " + b.Nome);
            }
            //***************************************************
            */
            /* ****************Exercicio - Classe Funcionario*****************
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();


            Console.WriteLine("Dados do primeiro Funcionário");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo Funcionário");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine());

            decimal media = a.Salario + b.Salario;
            media = media / 2;
            Console.WriteLine("Salário médio: " + media);
            //*******************************************
            */

            /* 
            ****************Classe Produto***************** 

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remover);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            */
            /* 
             * ****************Exercicio1 - Classe Retangulo***************** 
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            */
            /*
             ****************Exercicio2 - Classe Funcionario***************** 
            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            F.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + F);
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine());
            F.AumentarSalario(aumento);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + F);
            Console.WriteLine();
            */
            /*
            ****************Classe Static***************** 
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */
            /*
            ****************Exercicio - Classe Static *****************
            */
          

            Console.Write("Qual é a cotação do dolar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.Compra = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.IOF());
        }
    }
}