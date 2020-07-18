using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndNomeclatur
{
    public class Car : ISom
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Fabricacao { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Fazer bruuum");
        }
    }
}
