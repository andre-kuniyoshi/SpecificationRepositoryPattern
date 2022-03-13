namespace SpecificationRepositoryPattern.Core.Entities
{
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }
        public TipoMatricula TipoMatricula { get; set; }

        public int EnderecoId { get; set; }
        public int TipoMatriculaId { get; set; }
    }
}
