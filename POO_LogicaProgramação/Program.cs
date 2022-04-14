using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tipos
            int n1 = 2147483647;
            long n2 = 2147483648L;
            bool completoF = true;
            bool completoV = true;
            char genero = 'F';
            float n3 = 4.5f;
            double n4 = 4.5464355;
            string nome = "Wendell";
            object obj1 = "Juliany";
            object obj2 = 4.5f;
            int n5 = int.MinValue;
            int n6 = int.MaxValue;
            decimal n7 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(completoF);
            Console.WriteLine(completoV);
            Console.WriteLine(genero);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(n4.ToString("F2"));
            Console.WriteLine(n4.ToString("F4", CultureInfo.InvariantCulture));
            *************************************************
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Wendell";
            
            Console.WriteLine("{0} tem {1} e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {saldo:F2} reais");
        */
        /*  Exercicio
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 350.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {media}");
            Console.WriteLine($"Arredondado (três casas decimais): {media:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();
        
            Console.WriteLine("Digite um texto");
            
            string frase = Console.ReadLine();
            Console.WriteLine("Voce digitou: " + frase);

            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // string[] vet = s.Split('');
            //Split é uma função que serve para recorta rum astring em varios pedacinhos conforme o caracter que for passado
        

        // string nome;
        // char sexo;
        // int idade;
        // double altura;


        // nome = Console.ReadLine();
        // sexo = char.Parse(Console.ReadLine());
        // idade = int.Parse(Console.ReadLine());
        // altura = double.Parse(Console.ReadLine());
        
        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        char sexo = char.Parse(vet[1]);
        int idade = int.Parse(vet[2]);
        double altura = double.Parse(vet[3]);

        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura);
        // Console.Write("Digite o seu nome: ");
        // nome = Console.ReadLine();

        // Console.Write("Digite o seu sexo: ");
        // sexo = char.Parse(Console.ReadLine());

        // Console.Write("Digite a sua idade: ");
        // idade = int.Parse(Console.ReadLine());

        // Console.Write("Digite a sua altura: ");
        // altura = double.Parse(Console.ReadLine());

        // Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Idade: {idade} e Altura {altura}");

        string nome;
        int quarto;
        decimal preco;

        Console.WriteLine("Entre com seu nome completo: ");
        nome = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa? ");
        quarto = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço do produto: ");
        preco = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha):");
        string[] vet = Console.ReadLine().Split(' ');
        string snome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2]);

        Console.WriteLine(snome);
        Console.WriteLine(idade);
        Console.WriteLine(altura);

        ************************ funções ********************
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
           // int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("maior = " + resultado);   
        }        
        static int Maior(int a, int b, int c) {
            int m;
            if( a > b && a > c){
                m = a;
            } else if ( b > a && b > c){
                m = b;
            } else {
                m = c;
            }
            return m;
        }
        
        ****************** while *******************
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } 
            Console.WriteLine("Numero negativo!");

            ***************** for ***************
        */

        


        } 
    }
}