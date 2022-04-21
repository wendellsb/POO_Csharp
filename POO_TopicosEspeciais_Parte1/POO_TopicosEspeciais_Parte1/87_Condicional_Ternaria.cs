using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO_TopicosEspeciais_Parte1
{
    public class _87_Condicional_Ternaria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //operador ternario
            //                    condição    ?      sim    :      nao 
            double desconto  = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            /*
            // Forma normal - if/else
            if(preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            */
            

            Console.WriteLine(desconto);
        }
    }
}
