using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConjuntosModelo
{
    class Curso
    {
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private IDictionary<int, Aluno> dicionarioAlunos =
            new Dictionary<int, Aluno>();

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public void Matricular(Aluno aluno)
        {
            alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        //public Aluno BuscarMatriculado(int numeroMatricula)
        //{
        //    foreach (var aluno in alunos)
        //    {
        //        if (aluno.NumeroMatricula == numeroMatricula)
        //        {
        //            return aluno;
        //        }
        //    }
        //    throw new Exception("Matrícula não encontrada: " + numeroMatricula);
        //}

        public Aluno BuscarMatriculado(int numeroMatricula)
        {
            //return this.dicionarioAlunos[numeroMatricula];

            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }

        public void SubstituirAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }
    }
}
