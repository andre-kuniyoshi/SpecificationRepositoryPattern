using SpecificationRepositoryPattern.Core.Interfaces;
using System.Linq.Expressions;


namespace SpecificationRepositoryPattern.Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
        }

        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        protected void AddInclude(Expression<Func<T, object>> includedExpression)
        {
            Includes.Add(includedExpression);
        }

        //public Expression<Func<T, object>> OrderBy { get; private set; }

        //public Expression<Func<T, object>> OrderByDescending { get; private set; }

        //public int Take { get; private set; }

        //public int Skip { get; private set; }

        //public bool IsPagingEnabled { get; private set; }
    }
}
