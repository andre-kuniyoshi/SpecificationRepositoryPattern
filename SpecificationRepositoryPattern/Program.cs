using Microsoft.EntityFrameworkCore;
using SpecificationRepositoryPattern.Core.Entities;
using SpecificationRepositoryPattern.Core.Interfaces;
using SpecificationRepositoryPattern.Core.Specifications;
using SpecificationRepositoryPattern.Infrastructure;
using SpecificationRepositoryPattern.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IGenericRepository<Aluno>, GenericRepository<Aluno>>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add AppContext with Sql Server
var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddDbContext<MyAppContext>(options =>
{
    options.UseSqlite(connectionString);
});

var app = builder.Build();

var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = services.GetRequiredService<MyAppContext>();

await context.Database.MigrateAsync();
await ContextDataSeed.DataSeedAsync(context);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/Alunos", async (IGenericRepository<Aluno> genericAlunoRepo) => {

    var spec = new AlunoSpecification();
    var alunos = await genericAlunoRepo.ListAllAsync(spec);

    return alunos;
}).WithName("GetAlunos");

app.MapGet("/AlunosComEndereco", async (IGenericRepository<Aluno> genericAlunoRepo) => {

    var spec = new AlunoComEnderecoSpecification();
    var alunos = await genericAlunoRepo.ListAllAsync(spec);

    return alunos;

}).WithName("GetAlunosEndreco");

app.MapGet("/AlunosComEnderecoETipoMatricula", async (IGenericRepository<Aluno> genericAlunoRepo) => {

    var spec = new AlunoEnderecoTipoMatriculaSpecification();
    var alunos = await genericAlunoRepo.ListAllAsync(spec);

    return alunos;

}).WithName("GetAlunosEndrecoMatricula");

app.Run();
