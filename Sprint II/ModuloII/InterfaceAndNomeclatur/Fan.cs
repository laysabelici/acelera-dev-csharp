using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndNomeclatur
{
    //public class Fan : ISom, Laysa, posso usar varias
    public class Fan : ISom
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Barulho do vento");
        }
    }
}
