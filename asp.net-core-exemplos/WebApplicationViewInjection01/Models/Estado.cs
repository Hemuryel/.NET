using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationViewInjection01.Models
{
    public class Estado
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Estado(string nome, string sigla)
        {
            this.Nome = nome;
            this.Sigla = sigla;
        }
    }
}
