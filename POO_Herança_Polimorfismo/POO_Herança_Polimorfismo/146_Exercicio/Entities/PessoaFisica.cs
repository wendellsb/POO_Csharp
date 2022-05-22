namespace POO_Herança_Polimorfismo._146_Exercicio.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double Calculo()
        {
            if (RendaAnual <= 20000.00)
            {
                RendaAnual = (RendaAnual * 0.15) - (GastosSaude * 0.50);
            }
            else if (RendaAnual > 20000.00)
            {
                RendaAnual = (RendaAnual * 0.25) - (GastosSaude * 0.50);
            }
            return RendaAnual;
        }
    }
}
