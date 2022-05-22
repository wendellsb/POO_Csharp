using POO_Herança_Polimorfismo._143_Classes_Abstratas.Entities;
using POO_Herança_Polimorfismo._143_Classes_Abstrataso.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_Herança_Polimorfismo._143_Classes_Abstratas
{
    public class Run
    {
        static void Main(string[] args)
        {
            //            Classes abstratas
            // - São classes que não podem ser instanciadas
            // - É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas, 
            // mas nunca a superclasse abstrata
            //
            //                Exemplo
            //Suponha que em um negócio relacionado a banco, apenas contas poupança e contas para empresas são permitidas.
            //Não existe conta comum.
            //
            //Para garantir que contas comuns não possam ser instanciadas, basta acrescentarmos a palavra "abstract" na
            //declaração da classe.

            //Notação UML: itálico

            //            Questionamento
            //• Se a classe Account não pode ser instanciada, por que simplesmente não criar somente SavingsAccount e BusinessAccount?
            //
            //• Resposta:
            //• Reuso
            //• Polimorfismo: a superclasse classe genérica nos permite tratar de forma fácil e uniforme todos os tipos de conta,
            //inclusive com polimorfismo se for o caso (como fizemos nos últimos exercícios). Por exemplo, você pode colocar todos
            //tipos de contas em uma mesma coleção.
            //• Demo: suponha que você queira:
            //• Totalizar o saldo de todas as contas.
            //• Sacar 10.00 de todas as contas.

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Update balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }









        }
    }
}
