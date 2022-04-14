using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Classes
{
    internal class ConversorDeMoeda
    {
        public static double Cotacao;

        public static double Compra;

        public static double IOF()
        {
            return ((Cotacao * Compra) * 1.06) ;

        }
    }
}
