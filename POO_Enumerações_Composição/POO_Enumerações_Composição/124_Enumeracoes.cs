using POO_Enumerações_Composição.Entities;
using POO_Enumerações_Composição.Entities.Enums;
using System;

namespace POO_Enumerações_Composição
{
    public class _124_Enumeracoes
    {

        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
