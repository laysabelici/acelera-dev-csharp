﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LinqAndLambda.Modelagem
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
    }
}
