using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _73_ModifDeParamRefEOut
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculadora.Triple(a, out triple);
            Console.WriteLine(triple);

            /*
             * Diferença:
             * A variavel passada como parametro ref deve ter sido iniciada
             * A variavel ássada como parametro  out nao precisa ter sido iniciada
             * 
             * Ambos sao muito similares, mas ref é uma forma de fazer o compilador obrigar o usuario a iniciar a variavel
             */
        }
    }
}
