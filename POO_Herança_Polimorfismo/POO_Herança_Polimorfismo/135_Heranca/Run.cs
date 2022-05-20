using POO_Herança_Polimorfismo._135_Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança_Polimorfismo._135
{
    public class Run
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 400.0, 500.0);

            Console.WriteLine("Numero da conta: " + account.Number);
            Console.WriteLine("Nome: " + account.Holder);
            Console.WriteLine("Saldo: " + account.Balance);
            Console.WriteLine("Limite de emprestimo: " + account.LoanLimit);

            account.Deposit(600.0);
            Console.WriteLine("Novo limite apos deposito de " + 600.0 + ": " + account.Balance);

            account.Withdraw(300.0);
            Console.WriteLine("Novo limite apos saque de " + 300.0 + ": " + account.Balance);

            account.Loan(600.0);
            Console.WriteLine("Novo limite apos emprestimo de " + 600.0 + ": " + account.Balance);
        }
    }
}
