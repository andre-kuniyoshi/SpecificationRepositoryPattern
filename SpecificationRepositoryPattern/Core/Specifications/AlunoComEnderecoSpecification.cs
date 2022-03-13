using SpecificationRepositoryPattern.Core.Entities;

namespace SpecificationRepositoryPattern.Core.Specifications
{
    public class AlunoComEnderecoSpecification : BaseSpecification<Aluno>
    {
        public AlunoComEnderecoSpecification()
        {
            AddInclude(x => x.Endereco);
        }
    }
}
