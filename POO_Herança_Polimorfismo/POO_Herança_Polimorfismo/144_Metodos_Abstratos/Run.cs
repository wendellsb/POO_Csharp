using POO_Herança_Polimorfismo._144_Metodos_Abstratos.Entities;
using POO_Herança_Polimorfismo._144_Metodos_Abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_Herança_Polimorfismo._144_Metodos_Abstratos
{
    public class Run
    {
        static void Main(string[] args)
        {
            //            Métodos abstratos
            //• São métodos que não possuem implementação.
            //• Métodos precisam ser abstratos quando a classe é genérica demais para conter sua implementação.
            //• Se uma classe possuir pelo menos um método abstrato, então esta classe também é abstrata.
            //• Notação UML: itálico

            Console.Write("Enter the number of shapes: ");
            int number = int.Parse(Console.ReadLine());

            List<Shape> lista = new List<Shape>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangule or Circle (r/c) ?  ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'r')
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new Rectangle(width, height, color));  
                }
                else
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());

                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circle(radius, color));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Shape Areas: ");
            foreach (Shape item in lista)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
