using POO_Interfaces._204_Solução_Sem_Interface.Entities;
using System;
using System.Globalization;

namespace POO_Interfaces._204_Solução_Sem_Interface
{
    class Run
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/YYYY hh:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH/mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/YYYY hh:mm)");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH/mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        }
    }
}
