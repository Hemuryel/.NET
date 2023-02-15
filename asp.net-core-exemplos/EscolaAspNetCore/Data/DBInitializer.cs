using EscolaAspNetCore.Models;
using System;
using System.Linq;

namespace EscolaAspNetCore.Data
{
    public class DBInitializer
    {
        public static void Initialize(EscolaContext context)
        {
            context.Database.EnsureCreated();

            //// prfocurar por estudantes
            if (context.Estudantes.Any())
            {
                return;   // o banco de dados ja foi inicializado
            }

            var estudantes = new Estudante[]
            {
            new Estudante{Nome="Macoratti",DataMatricula=DateTime.Parse("2017-09-01")},
            new Estudante{Nome="Janice",DataMatricula=DateTime.Parse("2017-08-05")},
            new Estudante{Nome="Jefferson",DataMatricula=DateTime.Parse("2017-07-03")},
            new Estudante{Nome="Bianca",DataMatricula=DateTime.Parse("2017-08-11")},
            new Estudante{Nome="Jessica",DataMatricula=DateTime.Parse("2017-06-05")},
            new Estudante{Nome="Mario",DataMatricula=DateTime.Parse("2017-08-10")},
            };
            foreach (Estudante s in estudantes)
            {
                context.Estudantes.Add(s);
            }
            context.SaveChanges();

            var cursos = new Curso[]
            {
            new Curso{Titulo="Quimica",Creditos=3},
            new Curso{Titulo="Contabilidade",Creditos=3},
            new Curso{Titulo="Economia",Creditos=3},
            new Curso{Titulo="Calculo",Creditos=4},
            new Curso{Titulo="Trigonometria",Creditos=4},
            new Curso{Titulo="Ingles",Creditos=3},
            new Curso{Titulo="Literatura",Creditos=4}
            };
            foreach (Curso c in cursos)
            {
                context.Cursos.Add(c);
            }
            context.SaveChanges();

            var matriculas = new Matricula[]
            {
            new Matricula{EstudanteId=1,CursoId=1,Nota=Nota.A},
            new Matricula{EstudanteId=1,CursoId=4,Nota=Nota.C},
            new Matricula{EstudanteId=1,CursoId=4,Nota=Nota.B},
            new Matricula{EstudanteId=2,CursoId=1,Nota=Nota.B},
            new Matricula{EstudanteId=2,CursoId=3,Nota=Nota.F},
            new Matricula{EstudanteId=2,CursoId=2,Nota=Nota.F},
            new Matricula{EstudanteId=3,CursoId=1},
            new Matricula{EstudanteId=4,CursoId=1},
            new Matricula{EstudanteId=4,CursoId=4,Nota=Nota.F},
            new Matricula{EstudanteId=5,CursoId=4,Nota=Nota.C},
            new Matricula{EstudanteId=6,CursoId=1,Nota=Nota.B},
            };
            foreach (Matricula e in matriculas)
            {
                context.Matriculas.Add(e);
            }
            context.SaveChanges();
        }
    }
}
