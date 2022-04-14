﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO_ConstrutoresEncapsulamento
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //Construtor
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) : this (numero, titular)
        {
            Deposito(depositoInicial);
        }
        //

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = (Saldo - quantia) - 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
