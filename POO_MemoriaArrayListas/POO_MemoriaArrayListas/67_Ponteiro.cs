using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class _67_Ponteiro
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}
