using System.Globalization;

namespace POO_MemoriaArrayListas
{
    public class _70_Vetores
    {
        static void Main(string[] args)
        {
            // ******************* Vetor ******************
            // *******************Exercicio 2 *************
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

            double media = sum / n;
            Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
