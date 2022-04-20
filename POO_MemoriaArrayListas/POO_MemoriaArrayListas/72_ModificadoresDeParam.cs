using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _72_ModificadoresDeParam
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Sum(2, 3);
            int s2 = Calculadora.Sum(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
