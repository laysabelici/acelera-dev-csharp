﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambda.Modelagem
{
    public class Turma
    {
        public int Id { get; set; }
        public string NomeDaTurma { get; set; }
        public int IdCurso { get; set; }
        public int IdProfessor { get; set; }
        public List<int> Alunos { get; set; }
    }
}
