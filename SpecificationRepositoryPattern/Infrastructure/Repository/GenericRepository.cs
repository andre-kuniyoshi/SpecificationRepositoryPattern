using Microsoft.EntityFrameworkCore;
using SpecificationRepositoryPattern.Core.Entities;
using SpecificationRepositoryPattern.Core.Interfaces;

namespace SpecificationRepositoryPattern.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly MyAppContext _context;

        public GenericRepository(MyAppContext context)
        {
            _context = context;
        }

        public async Task<T> GetEntityWithSpecification(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> ListAllAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).ToListAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> specification)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), specification);
        }
    }
}
