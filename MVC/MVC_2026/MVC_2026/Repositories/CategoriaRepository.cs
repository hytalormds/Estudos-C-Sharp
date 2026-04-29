using MVC_2026.Context;
using MVC_2026.Models;
using MVC_2026.Repositories.Interfaces;

namespace MVC_2026.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
