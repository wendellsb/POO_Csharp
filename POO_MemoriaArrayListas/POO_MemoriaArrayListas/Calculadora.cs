using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class Calculadora
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        /*
        // referencia = ref
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        */
        // Saida de resultado = out
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }

    }
}
