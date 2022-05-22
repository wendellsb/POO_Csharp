using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Herança_Polimorfismo._144_Metodos_Abstratos.Entities.Enums;

namespace POO_Herança_Polimorfismo._144_Metodos_Abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
           return Math.PI * Radius * Radius;
        }
    }
}
