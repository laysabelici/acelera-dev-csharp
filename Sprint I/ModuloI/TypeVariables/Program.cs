using System;

namespace TypeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Laysa";
            var sobrenome = "Belici";
            int idade = 28;

            Console.WriteLine($"Meu nome é {nome} {sobrenome}, tenho {idade} de idade.");
        }
    }
}
