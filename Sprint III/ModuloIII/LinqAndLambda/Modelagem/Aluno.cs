using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambda.Modelagem
{
    public class Aluno : Pessoa
    {
        public bool Aprovado { get; set; }
        public decimal Media { get; set; }
        public int Faltas { get; set; }
    }
}
