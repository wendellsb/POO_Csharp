using POO_Herança_Polimorfismo._136_Upcasting_Downcasting.Entities;
using System;

namespace POO_Herança_Polimorfismo._136_Upcasting_Downcasting
{
    class Run
    {
        static void Main(string[] args)
        {
            // Upcasting
            // - Casting da subclasse para superclasse
            // - Uso comum: polimorfismo

            // Downcasting
            // - Casting da superclasse para subclasse
            // - Palavra "as"
            // - Palavra "is"
            // - Uso comum: métodos que recebem parâmetros genericos (Ex: Equals) 

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting - conversão da subclasse para superclasse
            // o businessaccount é um account, logo a variavel account recebe qualquer objeto de uma subclasse dela
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // Donwcasting é uma operação insegura e nescessita o teste para ver se a variavel é do tipo que vc quer
            // primeiro tem que converter o acc2 para o tipo BusinessAccount
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0); //esta operação só é do BusAcc           
            Console.WriteLine(acc4.Balance);

            //BusinessAccount acc5 = (BusinessAccount)acc3; erro de converção

            // testa se a variavel acc3 for uma instancia de BusinessAccount
            if (acc3 is BusinessAccount) // "is" - testa se acc3 é do tipo BusinessAccount
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // "as" - testa se acc3 é como BusinessAccount
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; // "as" - testa se acc3 é como SavingsAccount
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
