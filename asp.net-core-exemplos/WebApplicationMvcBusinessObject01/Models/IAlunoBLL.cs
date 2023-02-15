using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMvcBusinessObject01.Models
{
    // BLL = Business Logic Layer
    public interface IAlunoBLL
    {
        List<Aluno> GetAlunos();
        public void IncluirAluno(Aluno aluno);
        public void AtualizarAluno(Aluno aluno);
        void DeletarAluno(int id);
    }
}
