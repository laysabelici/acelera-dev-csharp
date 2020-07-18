using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Doguinho thorzinho = new Doguinho();
            thorzinho.CorDoPelo = "Marron e preto";
            thorzinho.Id = 1;
            thorzinho.Nome = "Thor Cavalcante";
            thorzinho.NomeDoDono = "Diego";
            thorzinho.Porte = "Médio";

            thorzinho.Comer();
            Console.WriteLine(thorzinho.Latir());
            thorzinho.Passear(true);
        }
    }
}
