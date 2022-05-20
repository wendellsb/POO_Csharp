﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança_Polimorfismo._139_Polimorfismo
{
    internal class Run
    {
        //        Polimorfismo
        // Em Programação Orientada a Objetos, polimorfismo é recurso que permite que variáveis
        // de um mesmo tipo mais genérico possam apontar para objetos de tipos específicos diferentes,
        // tendo assim comportamentos diferentes conforme cada tipo específico.

        // acc é do tipo Account e foi instanciada com o objetos diferentes vão ter comportamentos diferentes
        // Account acc1 = new Account(1001, "Alex", 500.0);
        // Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
        //        acc1.Withdraw(10.0);
        //        acc2.Withdraw(10.0);
        //        Console.WriteLine(acc1.Balance);
        //        Console.WriteLine(acc2.Balance);

        //        Importante entender
        // • A associação do tipo específico com o tipo genérico é feita em tempo de
        // execução(upcasting).
        // • O compilador não sabe para qual tipo específico a chamada do método
        // Withdraw está sendo feita(ele só sabe que são duas variáveis tipo Account) :

        // Account acc1 = new Account(1001, "Alex", 500.0);
        // Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
        // acc1.Withdraw(10.0); // saque 10 - retorno 485
        // acc2.Withdraw(10.0); // saque 10 - retorno 483
    }
}
