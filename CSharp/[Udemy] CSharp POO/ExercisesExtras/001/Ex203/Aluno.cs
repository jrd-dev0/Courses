using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex203
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public string Situacao()
        {
            if (NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }
        public double NotaReprovado()
        {
            return 60 - NotaFinal();
        }
    }
}
