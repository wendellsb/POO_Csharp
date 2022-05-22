﻿using POO_Herança_Polimorfismo._143_Classes_Abstratas.Entities;

namespace POO_Herança_Polimorfismo._143_Classes_Abstrataso.Entities
{

    class BusinessAccount : Account // Herdando tudo que account tem
    {
        public double LoanLimit { get; set; } // limite de emprestimo

        public BusinessAccount()
        {
        }

        // : base(parametros) - forma de herdar os parametros do construtor da classe account
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}