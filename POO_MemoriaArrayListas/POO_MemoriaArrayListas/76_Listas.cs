using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _76_Listas
    {
        static void Main(string[] args)
        {
            /*
             * Inserir elemento na lista: 
             * list.Add, list.Insert
             * 
             * Tamanho da lista: 
             * list.Count
             * 
             * Encontrar primeiro ou ultimo elemento da lista que satisfaça um predicado:
             * list.Find, list.FindLast
             * 
             * Encontrar primeiro ou ultima posição de elemento da lista que satisfaça um predicado:
             * list.FindIndex, list.FindLastIndex
             * 
             * Filtrar a lista com base em um predicado:
             * list.FindAll
             * 
             * Remover elementos da lista: 
             * list.Remove, list.RemoveAll, list.RemoveAt, list.RemoveRange
             * 
             * Como criar uma lista sem parametros
             * List<string> list = new List<string>();
             * 
             * * Como criar uma lista com parametros
             * List<string> list2 = new List<string> { "Maria", "Alex" 
             */
            
            List<string> list = new List<string>();
            // Add
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // Insert
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Count
            Console.WriteLine("List count: " + list.Count);

            // Find
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome com a letra 'A': " + s1);

            // FindLast
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome com a letra 'A': " + s2);

            // FindIndex
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de quem começa com a letra 'A': " + pos1);

            // FindLastIndex
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição de quem começa com a letra 'A': " + pos2);

            // FindAll - cria lista de string que recebe todos os itens da lista de tamanho igual a 5
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remove - removendo Alex
            list.Remove("Alex");
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // RemoveAll
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            // RemoveAt
            list.RemoveAt(2);
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // RemoveRagnge -  a partir da posição 2 remover 2 elementos
            list.RemoveRange(2, 2);
            Console.WriteLine("---------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
