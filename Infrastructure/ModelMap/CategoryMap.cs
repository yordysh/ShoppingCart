using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Category;

namespace Infrastructure.ModelMap
{
    public class CategoryMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
           builder.ToTable("Categoria");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("IdCategoria");
            builder.Property(c => c.Descripcion).HasColumnName("Descripcion");
            builder.Property(c => c.Activo).HasColumnName("Activo");
            builder.Property(c => c.FechaRegistro).HasColumnName("FechaRegistro");
        }
    }
}
