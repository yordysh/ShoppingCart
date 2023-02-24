using Application.Dtos.Category;
using Application.Services.Category.Abstractions;
using AutoMapper;
using Infrastructure.Repositories.Category.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Category.Implementations
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(IMapper mapper, ICategoriaRepository categoriaRepository)
        {
            _mapper= mapper;
            _categoriaRepository= categoriaRepository;
        }
        public Task<IList<CategoriaDto>> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
