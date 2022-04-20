using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace POO_MemoriaArrayListas
{
    public class _68_Nullable
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            Console.WriteLine(y.HasValue);
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            //******** exemplo de forma comprimida ********* //
            x = null;
            y = 10;
            // se x for nulo ?? então vai receber o valor 5
            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}