using SpecificationRepositoryPattern.Core.Entities;
using System.Text.Json;

namespace SpecificationRepositoryPattern.Infrastructure
{
    public class ContextDataSeed
    {
        public static async Task DataSeedAsync(MyAppContext context)
        {
            try
            { 
                if (!context.TiposMatricula.Any())
                {
                    var tiposMatriculasData = File.ReadAllText("./Infrastructure/DataSeed/TiposMatricula.json");
                    var tiposMatriculas = JsonSerializer.Deserialize<List<TipoMatricula>>(tiposMatriculasData);

                    foreach (var item in tiposMatriculas)
                    {
                        context.TiposMatricula.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Enderecos.Any())
                {
                    var enderecosData = File.ReadAllText("./Infrastructure/DataSeed/Enderecos.json");
                    var enderecos = JsonSerializer.Deserialize<List<Endereco>>(enderecosData);

                    foreach (var item in enderecos)
                    {
                        context.Enderecos.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Alunos.Any())
                {
                    var alunosData = File.ReadAllText("./Infrastructure/DataSeed/Alunos.json");
                    var alunos = JsonSerializer.Deserialize<List<Aluno>>(alunosData);

                    foreach (var item in alunos)
                    {
                        context.Alunos.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao tentar adicionar dados no banco!");
                Console.WriteLine(ex);
            }
        }
    }

    public class AlunoDto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public int Idade { get; private set; }
        public int EnderecoId { get; private set; }
        public int TipoMatriculaId { get; private set; }
    }
}
