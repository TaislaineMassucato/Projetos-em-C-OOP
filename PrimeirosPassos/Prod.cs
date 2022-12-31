using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Prod
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Prod(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
