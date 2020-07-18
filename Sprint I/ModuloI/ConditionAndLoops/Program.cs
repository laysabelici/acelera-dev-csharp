using System;

namespace ConditionAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade: ");
            int.TryParse(Console.ReadLine(), out int idade);

            if(idade<12)
            {
                Console.WriteLine("Criança.");
            }
            else if (idade>=12&&idade<18)
            {
                Console.WriteLine("Adolescente.");
            }
            else
            {
                Console.WriteLine("Adulto.");
            }

            //operador ternário
            string mensagem = idade >= 18 ? "Maior de idade." : "Menor de idade";
            Console.WriteLine(mensagem);

            Console.WriteLine("Mês de nascimento: ");
            var mes = Console.ReadLine();

            //opção de condional, para muitas opções a serem avaliadas
            switch (mes.ToLower())
            {
                case "dezembro":
                case "janeiro":
                case "fevereiro":
                    Console.WriteLine("Você nasceu no verão.");
                    break;
                default:
                    Console.WriteLine("Erro!");
                    break;
            }
        }
    }
}
