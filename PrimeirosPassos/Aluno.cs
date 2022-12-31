using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            double resul = Nota1 + Nota2 + Nota3;
            return resul;
        }

        public bool Aprovacao()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Restam()
        {
            if (Aprovacao())
            {
                return 0.0;
            }
            else
            {
                return 60 - NotaFinal();
            }
        }

    }
}
