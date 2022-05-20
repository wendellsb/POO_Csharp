namespace POO_Herança_Polimorfismo._138_Sealed.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } // taxa de jurus

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) // aproveitando o construtor da classe account
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // sobescrevendo o metodo Withdraw para não ter o desconto de 5 reais
        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}

        // Reaproveitando a operação da superclasse e acrescentando coisas depois
        // Essa operação nao pode ser sobrescriva novamente em outro subclasse
        public sealed override void Withdraw(double amount) 
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
