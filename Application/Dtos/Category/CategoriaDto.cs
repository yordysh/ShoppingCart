﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Category
{
    public class CategoriaDto
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Activo { get; set; } 
        public DateTime FechaRegistro { get; set; }
    }
}
