using AutoMapper;
using Domain.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Category.Maps
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Categoria, CategoriaDto>();
        }
    }
}
