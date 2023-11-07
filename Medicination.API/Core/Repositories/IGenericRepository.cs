using System.Linq.Expressions;

namespace Medicination.API.Core.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		IQueryable<T> GetAll();
		Task<T> GetById(string id);

		IQueryable<T> Where(Expression<Func<T, bool>> espression);
		Task AddAsync(T entity); 

		Task AddRangeAsync(IEnumerable<T> entities);

		void Update(T entity);
		void Delete(T entity);

		void RemoveRange(IEnumerable<T> entities);

	}
}
