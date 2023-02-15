using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWebAPI03.Models
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto Get(int id);
        Produto Add(Produto item);
        bool Update(Produto item);
        void Remove(int id);
    }
}
