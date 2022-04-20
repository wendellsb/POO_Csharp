namespace POO_MemoriaArrayListas
{
    public class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
