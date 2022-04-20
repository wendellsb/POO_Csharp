using System;
using System.Globalization;

namespace POO_MemoriaArrayListas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //***************** ponteiro ************************
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
            */
            /*
            // **************** Nullable *********************
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            Console.WriteLine(y.HasValue);
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");
            
            //******** exemplo de forma comprimida ********* //
            double? x = null;
            double? y = 10;
            // se x for nulo ?? então vai receber o valor 5
            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            // ******************* Vetor ******************
            // *******************Exercicio 1 *************
            Console.WriteLine("Informe o tamanho do vetor!");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Informe a posição {i}: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Posição {i}: Valor: {vect[i]} ");
            }
            */
            
            Console.Write("Informe o numero da lista: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o nome do Produto: ");
                string name = Console.ReadLine();
                
                Console.Write("Informe o preço do Produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vet[i] = new Produto(name, price) { Name = name, Price = price };
       
                Console.WriteLine();
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vet[i].Price;
            }

            double media = sum/ n;
            Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}