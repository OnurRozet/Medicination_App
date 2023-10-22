using System.Linq.Expressions;

namespace Medicination.API.Core.Services
{
	public interface IService<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetById(int id);

		IQueryable<T> Where(Expression<Func<T, bool>> espression);
		Task<T> AddAsync(T entity);

		Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);

		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);

		Task RemoveRangeAsync(IEnumerable<T> entities);
	}
}
