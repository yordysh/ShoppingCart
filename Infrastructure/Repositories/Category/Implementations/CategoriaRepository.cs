using Domain.Category;
using Infrastructure.Context;
using Infrastructure.Repositories.Category.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Category.Implementations
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoriaRepository(ApplicationDbContext context)
        {
            _context= context;
        }
        //public async Task<IList<Categoria>> FindAll()
        //{
        //    var response = await _context.Categorias.ToListAsync();
        //    return response;
        //}
        public async Task<IList<Categoria>> FindAll()
         => await _context.Categorias.OrderByDescending(c => c.Id).ToListAsync();
         
        
    }
}
