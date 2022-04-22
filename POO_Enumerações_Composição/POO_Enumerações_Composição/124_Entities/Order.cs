﻿using POO_Enumerações_Composição.Entities.Enums;
using System;

namespace POO_Enumerações_Composição.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status; 
        }
    }
}
