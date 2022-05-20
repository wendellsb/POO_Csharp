using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança_Polimorfismo._136.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } // não permite modificação somente leitura
        public double Balance { get; protected set; } // permite modificações por subclasses

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
