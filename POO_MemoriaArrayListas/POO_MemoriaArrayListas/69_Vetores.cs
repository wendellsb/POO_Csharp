using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _69_Vetores
    {
        static void Main(string[] args)
        {
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
        }
    }
}
