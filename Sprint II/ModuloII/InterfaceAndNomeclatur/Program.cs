using System;

namespace InterfaceAndNomeclatur
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface é o contrato entre a classe e o mundo exterior
            //Quando uma classe implementa uma interface, se compromete
            //a fornecer o comportamento publicado por essa interface

            //Uma interface define um contrato
            //Qualquer classe que implemente esse contrato deve fornecer
            //uma implementação dos membros definidos na interface.

            //Namespace é semelhante ao conceito de uma pasta do sistema 
            // de arquivos de uma computador
            //Ele agrupa classes e tipos por semantica e é declarado
            //como palavra chave nomespace

            new Car().EmitirSom();
            new Cat().EmitirSom();
            new Fan().EmitirSom();
        }
    }
}
