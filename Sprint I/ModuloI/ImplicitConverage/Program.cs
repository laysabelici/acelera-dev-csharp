using System;
using System.Collections.Generic;
using System.Data;

namespace ImplicitConverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte: short, int, long, float, double, decimal
            //byte: short, ushort, int, unit, long, ulong, float, double, decimal
            //short: int, long, float, double, decimal
            //ushort: int, uint, long, ulong, float, double, decimal
            //int: long, float, doublem, decimal
            //uint: long, ulong, float, double, decimal
            //long: float, double, decimal
            //ulong: float, double, decimal
            //char: ushort, int, unit, long, ulong, float, double, decimal
            //float: double
            //Classe filha: classe pai
            //interpolação

            Programadora dev = new Programadora();
            dev.Nome = "Laysa";
            dev.AnosDeCarreira = 11;
            dev.ConheceMetologiaAgil = true;
            dev.DataAdmissao = new DateTime(2020, 03, 03);
            dev.DataNascimento = new DateTime(1991, 07, 01);
            dev.Id = 5;
            dev.Linguagens = new List<string>() { "C#", "JavaScript" };

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Diego";
            funcionario.DataAdmissao = new DateTime(2020, 06, 06);
            funcionario.DataNascimento = new DateTime(1998, 03, 04);

            int varInt = 20;
            long varLong = varInt;

            float varFloat = 10.5F;
            double varDouble = varFloat;

            char varChar = 'T';
            int varInt1 = varChar;

            string meuTexto = $"Conversão implícita:" +
            $"Variável inteira {varInt} e variável float {varFloat}";

            Funcionario devfunc = dev;

            Console.WriteLine($"Int para long: {varLong}");
            Console.WriteLine($"Float para double: {varDouble}");
            Console.WriteLine($"Char para int: {varInt1}");
            Console.WriteLine($"Implicita por interpolação: {meuTexto}");
            Console.WriteLine($"Classe filha para classe pai: " +
                $"Nome {devfunc.Nome}," +
                $"data de admissão: {devfunc.DataAdmissao:dd/MM/yyyy}," +
                $"data nascimento: {devfunc.DataNascimento:dd/MM/yyyy}.");

            //Conversão explícita

            long varLongExp = 9223372036854775807;
            int varIntExp = (int)varLongExp;

            varInt = (int)varLong;
            string longParaString = varLong.ToString();
            decimal varDecimal = Convert.ToDecimal("15,2");
            varDecimal += 10;
            decimal.TryParse("morango", out decimal varDecimalTry);
            decimal.TryParse("17", out decimal varDecimalTry1);

            if (devfunc is Programadora info)
                Console.WriteLine($"Func e programadora: {info.Nome}");
            if (funcionario is Programadora infoFunc)
                Console.WriteLine($"Func e programadora: {infoFunc.Nome}");

            Console.WriteLine($"long(max) para int: {varIntExp}");
            Console.WriteLine($"long para int: {varInt}");
            Console.WriteLine($"long para string: {longParaString}");
            Console.WriteLine($"string para decimal: {varDecimal}");
            Console.WriteLine($"string para decimal via tryParse: {varDecimalTry}");
            Console.WriteLine($"string para decimal via tryparse: {varDecimalTry1}");
        }

    }
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }

    }
    public class Programadora : Funcionario
    {
        public List<string> Linguagens { get; set; }
        public bool ConheceMetologiaAgil { get; set; }
        public int AnosDeCarreira { get; set; }
    }
}