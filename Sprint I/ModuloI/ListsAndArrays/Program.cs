using System;
using System.Collections.Generic;

namespace ListsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array: precisa definir o tamanho ao declarar a variável
            string[] nomes = new string[5];
            nomes[0] = "Ana";
            nomes[1] = "Lucia";
            nomes[2] = "Bardo";
            nomes[3] = "Laysa";
            nomes[4] = "Thamires";

            Console.WriteLine($"Nome: {nomes[0]}.");

            //Para muitos valores
            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("Gameiro");
            sobrenomes.Add("Oliveira");
            sobrenomes.Add("Silva");
            sobrenomes.Add("Belici");
            sobrenomes.Add("Souza");
        }
    }
}
