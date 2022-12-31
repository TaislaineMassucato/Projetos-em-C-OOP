using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Empregado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }


        public Empregado(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }
       public static void Aumento(double dimdim)
        {
            dimdim += dimdim * dimdim / 100.0;
        }
        public override string ToString()
        {
            return ID 
                +","
                +Nome
                +","
                +Salario;
        }
    }
}
