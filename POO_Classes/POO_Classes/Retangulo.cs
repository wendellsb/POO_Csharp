using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Classes
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;
        
        public double Area()
        {
        return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
    }

    

}
