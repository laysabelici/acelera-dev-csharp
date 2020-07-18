﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Pessoa
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Nome { get; set; }
        public bool SexoFeminino { get; set; }

        public virtual void Comer()
        {
            Console.WriteLine("Peguei os talheres e iniciei minha refeição");
        }
        public virtual void TomarBanho()
        {
            Console.WriteLine($"Eu {Nome} estou iniciando meu banho");
        }

        public abstract void Andar();
    }
}
