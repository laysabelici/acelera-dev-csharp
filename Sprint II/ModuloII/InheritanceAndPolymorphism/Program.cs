using System;
using Encapsulation;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Adulto thamy = new Adulto(1, "Thamires");
            thamy.DataDeNascimento = new DateTime(1991, 07, 01);
            thamy.SexoFeminino = true;

            Bebe gio = new Bebe(2,"Davi")
            {
                DataDeNascimento = new DateTime(1991, 07, 01),
                SexoFeminino = true
            };
            thamy.Comer();
            thamy.TomarBanho();
            thamy.Andar();
            Console.WriteLine();

            gio.Comer();
            gio.TomarBanho();
            gio.Andar();

            ClassPublic publica = new ClassPublic();
            publica.MinhaPropPublica = 10;

            //abstrata
            Console.WriteLine(Calculo.Somar(10, 5));
            Adulto.DizerBomDia();

        }
    }
    //COLOCAR EM OUTRO ARQUIVO SEMPRE
    //class MyClass : ClassPublic
    //{
    //    public void MeuMetodo()
    //    {
    //        base.MinhaPropProtectedInternal = 15;
    //    }
    //}
}
