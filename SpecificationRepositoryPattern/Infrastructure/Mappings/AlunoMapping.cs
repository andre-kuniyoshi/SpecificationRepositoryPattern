using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpecificationRepositoryPattern.Core.Entities;

namespace SpecificationRepositoryPattern.Infrastructure.Mappings
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(a => a.Nome).IsRequired().HasColumnType("varchar(50)");
            builder.Property(a => a.Sobrenome).IsRequired().HasColumnType("varchar(50)");
            builder.Property(a => a.Idade).IsRequired().HasColumnType("integer");

            builder.HasOne(a => a.Endereco).WithOne();
            builder.HasOne(a => a.TipoMatricula).WithOne();

            builder.ToTable("Alunos");
        }
    }
}
