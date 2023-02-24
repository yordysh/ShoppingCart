using Domain.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Category.Abstractions
{
    public interface ICategoriaRepository
    {
        Task<IList<Categoria>> FindAll();
    }
}
