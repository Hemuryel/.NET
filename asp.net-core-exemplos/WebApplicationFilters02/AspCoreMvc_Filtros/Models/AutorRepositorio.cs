using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreMvc_Filtros.Models
{
    public class AutorRepositorio : IAutorRepositorio
    {
        private readonly AutorDbContext _dbContext;

        public AutorRepositorio(AutorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Autor> GetByIdAsync(int id)
        {
            return await _dbContext.Autores.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Autor>> ListAsync()
        {
            return await _dbContext.Autores.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(Autor autor)
        {
            _dbContext.Entry(autor).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddAsync(Autor autor)
        {
            if (!_dbContext.Autores.Any())
            {
                autor.Id = 1;
            }
            else
            {
                int maxId = _dbContext.Autores.Max(a => a.Id);
                autor.Id = maxId + 1;
            }
            _dbContext.Autores.Add(autor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var author = _dbContext.Autores.FirstOrDefault(a => a.Id == id);
            _dbContext.Autores.Remove(author);
            await _dbContext.SaveChangesAsync();
        }
    }
}
