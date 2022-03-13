using Microsoft.EntityFrameworkCore;
using SpecificationRepositoryPattern.Core.Entities;

namespace SpecificationRepositoryPattern.Infrastructure
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<TipoMatricula> TiposMatricula { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
