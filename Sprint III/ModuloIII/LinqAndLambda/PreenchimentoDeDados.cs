using LinqAndLambda.Modelagem;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAndLambda
{
    public static class PreenchimentoDeDados
    {
        public static List<Aluno> CriarAlunos()
        {
            return new List<Aluno>()
            {
                new Aluno()
                {
                    Id = 1,
                    Nome = "João",
                    Telefone = "1111-1111",
                    DataNasc = new DateTime (1990, 05, 30),
                    Email = "joao@gmail.com"
                },
                new Aluno()
                {
                    Id = 2,
                    Nome = "Maria",
                    Telefone = "2222-2222",
                    DataNasc = new DateTime (1991, 11, 23),
                    Email = "maria@gmail.com"
                },
                new Aluno()
                {
                    Id = 3,
                    Nome = "Raquel",
                    Telefone = "3333-3333",
                    DataNasc = new DateTime (1992, 10, 21),
                    Email = "raquel@gmail.com"
                }
            };
        }
        public static List<Curso> CriarCursos()
        {
            return new List<Curso>()
            {
                new Curso()
                {
                    Id = 1,
                    NomeDoCurso = "C#",
                    Descricao = "Iniciantes"
                },
                new Curso()
                {
                    Id = 2,
                    NomeDoCurso = "JS",
                    Descricao = "Medio"
                },
                new Curso()
                {
                    Id = 3,
                    NomeDoCurso = "Java",
                    Descricao = "Full"
                }
            };
        }
        public static List<Professor> CriarProfessores()
        {
            return new List<Professor>()
            {
                new Professor()
                {
                    Id = 1,
                    DataNasc = new DateTime(1989, 12, 05),
                    Email = "abc@gmail.com",
                    Nome = "Paula",
                    Telefone = "1111-1234",
                    AptoParaCursos = new List<int>(){1,3}
                },
                new Professor()
                {
                    Id = 2,
                    DataNasc = new DateTime(1984, 14, 08),
                    Email = "abcefg@gmail.com",
                    Nome = "Marcia",
                    Telefone = "1231-1234",
                    AptoParaCursos = new List<int>(){2,3}
                },
                new Professor()
                {
                    Id = 3,
                    DataNasc = new DateTime(1990, 18, 07),
                    Email = "abcefghi@gmail.com",
                    Nome = "Paula",
                    Telefone = "1234-1234",
                    AptoParaCursos = new List<int>(){2,1}
                }
            };
        }
        public static List<Turma> CriarTurma()
        {
            return new List<Turma>()
            {
                new Turma()
                {
                    Id = 1,

                    Alunos = new List<int>(){1,2,3},
                    IdCurso = 1,
                    IdProfessor = 1,
                    NomeDaTurma = "T.I."
                }
            };
        }
    }
}
