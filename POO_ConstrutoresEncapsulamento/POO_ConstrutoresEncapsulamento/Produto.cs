﻿using System.Globalization;
namespace POO_ConstrutoresEncapsulamento
{
    class Produto
    {
        private string _nome;
        // auto properties
        public  double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //

        // prop + 2 tab

        //Construtores
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //fim

        // properties
        public string Nome { 
            get { 
                return _nome; 
            } 
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            } 
        } 
        //fim

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}