﻿using System;

namespace Session60Ex1
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Aluno(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}
