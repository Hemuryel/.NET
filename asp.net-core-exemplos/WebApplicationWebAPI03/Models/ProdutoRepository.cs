using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWebAPI03.Models
{
    public class ProdutoRepository : IProdutoRepository
    {
        private List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Produto01", Categoria = "Categoria01", Preco = 1.00M },
            new Produto { Id = 2, Nome = "Produto02", Categoria = "Categoria02", Preco = 2.00M },
            new Produto { Id = 3, Nome = "Produto03", Categoria = "Categoria03", Preco = 3.00M },
            new Produto { Id = 4, Nome = "Produto04", Categoria = "Categoria04", Preco = 4.00M },
            new Produto { Id = 5, Nome = "Produto05", Categoria = "Categoria05", Preco = 5.00M },
        };

        private int _nextId = 6;

        //public ProdutoRepository()
        //{
        //    Add(new Produto { Nome = "Produto01", Categoria = "Categoria01", Preco = 1.00M });
        //    Add(new Produto { Nome = "Produto02", Categoria = "Categoria02", Preco = 1.00M });
        //    Add(new Produto { Nome = "Produto03", Categoria = "Categoria03", Preco = 1.00M });
        //    Add(new Produto { Nome = "Produto04", Categoria = "Categoria04", Preco = 1.00M });
        //    Add(new Produto { Nome = "Produto05", Categoria = "Categoria05", Preco = 1.00M });
        //}

        public Produto Add(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentException("item");     
            }
            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentException("item");
            }

            int index = produtos.FindIndex(p => p.Id == item.Id);

            if (index == -1)
                return false;

            // por ser objeto na memória (e não no banco), requer remover e adicionar novamente
            produtos.RemoveAt(index);
            produtos.Add(item);

            return true;
        }
    }
}
