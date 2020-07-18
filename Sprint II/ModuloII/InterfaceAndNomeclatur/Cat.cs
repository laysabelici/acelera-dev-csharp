using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndNomeclatur
{
    public class Cat: ISom
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeDono { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Miauuu");
        }
    }
}
