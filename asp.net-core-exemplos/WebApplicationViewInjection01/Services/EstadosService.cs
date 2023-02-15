using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationViewInjection01.Models;

namespace WebApplicationViewInjection01.Services
{
    public class EstadosService
    {
        public List<Estado> GetEstados()
        {
            return new List<Estado>()
            {
                new Estado("São Paulo", "SP"),
                new Estado("Rio de Janeiro", "RJ"),
                new Estado("Minas Gerais", "MG"),
                new Estado("Paraná", "PR")
            };
        }
    }
}
