using SpecificationRepositoryPattern.Core.Entities;

namespace SpecificationRepositoryPattern.Core.Specifications
{
    public class AlunoEnderecoTipoMatriculaSpecification : BaseSpecification<Aluno>
    {
        public AlunoEnderecoTipoMatriculaSpecification()
        {
            AddInclude(x => x.Endereco);
            AddInclude(x => x.TipoMatricula);
        }
    }
}
