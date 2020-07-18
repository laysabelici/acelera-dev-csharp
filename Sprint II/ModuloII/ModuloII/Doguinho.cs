using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObject
{
    public class Doguinho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Porte { get; set; }
        public string NomeDoDono { get; set; }
        public string CorDoPelo { get; set; }

        //método para processar informação
        public void Comer()
        {
            Console.WriteLine($"O doguinho {Nome} começou a comer");
        }

        //método que retorna
        public string Latir()
        {
            return "Au au au";
        }

        //método que recebe parametro, informação externa
        public void Passear(bool estaChovendo)
        {
            if (estaChovendo)
                Console.WriteLine($"O doguinho {Nome} não pode passear");
            else
                Console.WriteLine($"O doguinho {Nome} vai passear");
        }
    }

}
