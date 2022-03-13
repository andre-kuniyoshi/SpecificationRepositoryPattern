using SpecificationRepositoryPattern.Core.Entities;

namespace SpecificationRepositoryPattern.Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetEntityWithSpecification(ISpecification<T> specification);
        Task<IEnumerable<T>> ListAllAsync(ISpecification<T> specification);
    }
}
