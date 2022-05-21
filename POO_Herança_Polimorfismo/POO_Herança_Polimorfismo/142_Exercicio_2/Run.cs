using POO_Herança_Polimorfismo._142_Exercicio_2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança_Polimorfismo._142_Exercicio_2
{
    public class Run
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> produto = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common (c), used (u) or importes (i) ?   ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    produto.Add(new UsedProduct(name, price, data));
                }
                else if ( resp == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    produto.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    produto.Add(new Product(name, price));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach (Product item in produto)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
