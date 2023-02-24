using Application.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Category.Abstractions
{
    public interface ICategoriaService
    {
        Task<IList<CategoriaDto>> FindAll();
    }
}
