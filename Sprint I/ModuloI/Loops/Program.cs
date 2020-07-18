using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //List and Array
            //array: precisa definir o tamanho ao declarar a variavel
            string[] nomes = new string[5];
            nomes[0] = "Ana";
            nomes[1] = "Lucia";
            nomes[2] = "Viviane";
            nomes[3] = "Amanda";
            nomes[4] = "Thamirys";

            Console.WriteLine($"Nome 1: {nomes[0]}");

            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("Gameiro");
            sobrenomes.Add("Oliveira");
            sobrenomes.Add("Silva");
            sobrenomes.Add("Viana");
            sobrenomes.Add("Souza");
            sobrenomes.Add("Nunes");

            //Loops

            for (int i = 0; i < sobrenomes.Count; i++)
            {
                Console.WriteLine($"Sobrenome {i + 1}: {sobrenomes[i]}");
            }
            Console.WriteLine();

            //roda todos os itens da lista

            foreach (string sobrenome in sobrenomes)
            {
                Console.WriteLine($"Sobrenome por foreach: {sobrenome}");
            }
            Console.WriteLine();

            //Foreach por outro modo

            sobrenomes.ForEach(sobrenome =>
                Console.WriteLine($"Sobrenome por foreach1: {sobrenome}"));
            Console.WriteLine();

            //Enquanto a condição for verdadeira
            int x = sobrenomes.Count - 1;
            while (x >= 0)
            {
                Console.WriteLine($"Sobrenome por while invertido: {sobrenomes[x]}");
                x--;
            }
            Console.WriteLine();

            //do while: quando precisa-se que o trecho de código seja executado todas as vezes sempre
            int y = 0;
            do
            {
                Console.WriteLine($"Nome por DO While: {nomes[y]}");
                y++;
            } while (y < nomes.Length);
        }
    }
}