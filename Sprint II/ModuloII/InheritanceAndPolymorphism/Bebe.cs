using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class Bebe : Pessoa
    {
        public Bebe(int id, string nome) : base(id, nome)
        {

        }
        public override void Andar()
        {
            Console.WriteLine($"{Nome} esta andando e brincando.");
        }

        public override void Comer()
        {
            var sexo = SexoFeminino ? "a" : "o";
            Console.WriteLine($"Algum adulto iniciou a alimentação d{sexo} {Nome}");
        }
        public override void TomarBanho()
        {
            var sexo = SexoFeminino ? "a" : "o";
            Console.WriteLine($"Algum adulto iniciou o banho d{sexo} {Nome}");
        }
        
    }
}
