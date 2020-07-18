using System;

namespace LogicOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para AND basta um FALSE, é usado && para AND:
            //true
            var Everdadeiro = true && true;
            //todos os outros false
            var Efalso1 = true && false;
            var Efalso2 = false && true;
            var Efalso3 = false && false;

            //Exemplo:
            Console.WriteLine(Everdadeiro);
            Console.WriteLine(Efalso1);
            Console.WriteLine(Efalso2);
            Console.WriteLine(Efalso3);

            //Para OR basta um TRUE, é usado || para OR:
            var Ouverdadeiro = true || true;
            var Ouverdadeiro1 = false || true;
            var Ouverdadeiro2 = true || false;
            var Ouverdadeiro3 = false || false;

            Console.WriteLine(Ouverdadeiro);
            Console.WriteLine(Ouverdadeiro1);
            Console.WriteLine(Ouverdadeiro2);
            Console.WriteLine(Ouverdadeiro3);

            //Variável oposta, inverte com !:
            var exemploVerdadeiro = !true;
            var exemploVerdadeiro1 = !Efalso1;

            Console.WriteLine(exemploVerdadeiro);
            Console.WriteLine(exemploVerdadeiro1);
        }
    }
}
