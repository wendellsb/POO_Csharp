namespace POO_Herança_Polimorfismo._137_Sobreposicao.Entities
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

        // virtual - informa que o metodo pode ser subscrito ou sobreposto nas subclasses
        public virtual void Withdraw(double amount) 
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
