
using System;

namespace InheritanceAndPolymorphism
{
    public class Adulto : Pessoa
    {
        public Adulto(int id, string nome) : base(id, nome)
        {

        }
        public override void Andar()
        {
            Console.WriteLine($"{Nome} comecçou a caminhar.");
        }

        public static void DizerBomDia()
        {
            Console.WriteLine("Bom dia");
        }
    }
}
