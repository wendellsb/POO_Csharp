using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Herança_Polimorfismo._146_Exercicio.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Calculo()
        {
            if(NumeroFuncionarios >= 10)
            {
                RendaAnual *= 0.14;
            }
            else
            {
                RendaAnual *= 0.16;
            }
            return RendaAnual;
        }
    }
}
