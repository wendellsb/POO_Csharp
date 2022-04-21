using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _79_Matrizes
    {
        static void Main(string[] args)
        {
            /* 
            * // Declaração de matrizes
            * double[,] mat = new double[2, 3];
            * Console.WriteLine("Quantos elementos a matriz tem no total: " + mat.Length);
            * Console.WriteLine("Primeira dimensão da matriz (quantidade de linhas): " + mat.Rank);
            * Console.WriteLine("Tamanho das linhas da matriz" + mat.GetLength(0));
            * Console.WriteLine("Tamanho das colunas da matriz" + mat.GetLength(1));
            */
            Console.Write("Informe qual a dimensão da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[,] matriz = new int[tamanho, tamanho]; 
            int contador = 0;

            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                {
                    Console.Write("Informe o numero para inserir na matriz: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                    
                    if(matriz[l, c] < 0)
                    {
                        contador += 1;
                    }  
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Diagonal pricipal:");
            for (int l = 0; l < tamanho; l++)
            {
                for (int c = 0; c < tamanho; c++)
                {
                    if (matriz[l, c] == matriz[l, c])
                    {
                        Console.Write(matriz[l, c]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de numeros negativos: " + contador);
            
        }
    }
}
