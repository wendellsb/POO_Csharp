using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_MemoriaArrayListas
{
    public class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumQuarto { get; set; }

        public Estudante(string nome, string email, int numQuarto)
        {
            Nome = nome;
            Email = email;
            NumQuarto = numQuarto;
        }

        public override string ToString()
        {
            return NumQuarto + ": " + Nome + ", " + Email;
        }
    }
}
