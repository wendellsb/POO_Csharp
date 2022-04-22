using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TopicosEspeciais_Parte1
{
    public class _89_DateTime
    {
        static void Main(string[] args)
        {
            // construtor 
            // d1 = new DateTime(ano, mes, dia);
            DateTime d1 = new DateTime(2018, 11, 25);
            // d2 = new DateTime(ano, mes, dia, hora, minuto, segundo);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            // d3 = new DateTime(ano, mes, dia, hora, minuto, segundo, milissegundo);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3 , 500);
            
            // Builders
            // data e horario atual
            DateTime d4 = DateTime.Now;
            // data de hora com 00 horas
            DateTime d5 = DateTime.Today;
            // data e hora com o padrão UTC (3 horas adiantado)
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            // passando a data por uma string
            DateTime d7 = DateTime.Parse("2000-08-15");
            // data e hora por string
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d9 = DateTime.Parse("2000/08/15");
            DateTime d10 = DateTime.Parse("2000/08/15 13:05:58");

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("2000-08-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
           
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
