using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TopicosEspeciais_Parte1
{
    public class _88_Funcoes_String
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG  ";
            // transforma os caracteres em maiusculos
            string s1 = original.ToUpper();

            // transforma os caracteres em minusculos
            string s2 = original.ToLower();

            // apaga os espaços depois e antes da string
            string s3 = original.Trim();

            // busca dentro da string a primeira ocorencia
            int n1 = original.IndexOf("bc");

            // busca dentro da string a ultima ocorrencia
            int n2 = original.LastIndexOf("bc");

            // recorta a string a partir do numero 3
            string s4 = original.Substring(3);

            // recorta 5 caracteres a partir da posição 3
            string s5 = original.Substring(3, 5);

            // substitui todo caracter 'a' pelo caracter 'x'
            string s6 = original.Replace('a', 'x');
            // substitui todo caracter 'a' pelo caracter 'x'
            string s7 = original.Replace("abc", "xy");
            
            // testa se a string é nula ou vazia
            bool b1 = String.IsNullOrEmpty(original);

            // testa se a variavel é nula oou tem espaços em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            // split - recorta uma string com base no caracter
            // int x = int.Parse(str) - converte string para inteiro

            Console.WriteLine("Original: " + original);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine("ToLower: " + s2);
            Console.WriteLine("Trim: " + s3);
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3, 5): " + s5);
            Console.WriteLine("Repalce('a', 'x'): " + s6);
            Console.WriteLine("Repalce('abc', 'xy'): " + s7);
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b1);
        }
    }
}
