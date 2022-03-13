using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpecificationRepositoryPattern.Core.Entities;

namespace SpecificationRepositoryPattern.Infrastructure.Mappings
{
    public class TipoMatriculaMapping : IEntityTypeConfiguration<TipoMatricula>
    {
        public void Configure(EntityTypeBuilder<TipoMatricula> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).IsRequired().HasColumnType("varchar(50)");
            
            builder.ToTable("TiposMatricula");

        }
    }
}
