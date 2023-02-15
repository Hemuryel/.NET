using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore01.Models
{
    // BLL = Business Logic Layer
    public interface IAlunoBLL
    {
        List<Aluno> GetAlunos();
    }
}
