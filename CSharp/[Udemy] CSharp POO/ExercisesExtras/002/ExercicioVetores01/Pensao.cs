using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetores01
{
    internal class Pensao
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pensao(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

    }
}
