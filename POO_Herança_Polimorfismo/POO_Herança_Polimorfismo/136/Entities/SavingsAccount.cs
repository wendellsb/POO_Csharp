﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança_Polimorfismo._136.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; } // taxa de jurus

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance) // aproveitando o construtor da classe account
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
