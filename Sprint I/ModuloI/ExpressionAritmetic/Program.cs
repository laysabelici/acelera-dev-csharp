using System;
using System.Runtime.Serialization;

namespace ExpressionAritmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 5;
            var soma = a + b;
            var subtracao = a - b;
            var multiplicacao = a * b;
            var divisao = a / b;
            var modulo = a % b;

            Console.WriteLine($"Soma: {soma}.");
            Console.WriteLine($"Subtracao: {subtracao}.");
            Console.WriteLine($"Multiplicacao: {multiplicacao}.");
            Console.WriteLine($"Divisao: {divisao}.");
            Console.WriteLine($"Modulo: {modulo}.");

        }
    }
}
