using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpecificationRepositoryPattern.Core.Entities;

namespace SpecificationRepositoryPattern.Infrastructure.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Logradouro).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.Numero).IsRequired().HasColumnType("varchar(50)");
            builder.Property(e => e.Bairro).IsRequired().HasColumnType("varchar(50)");
            builder.Property(e => e.Cidade).IsRequired().HasColumnType("varchar(50)");
            builder.Property(e => e.UF).IsRequired().HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}
