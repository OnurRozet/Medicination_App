using Medicination.API.Core.Repositories;
using Medicination.API.Core.Services;
using Medicination.API.Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Medicination.API.Services.Services
{
	public class Service<T> : IService<T> where T : class
	{

		protected readonly IGenericRepository<T> _repository;
		private readonly IUnitOfWork _unitOfWork;

		public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
		{
			_repository = repository;
			_unitOfWork = unitOfWork;
		}

		public async Task<T> AddAsync(T entity)
		{
			await _repository.AddAsync(entity);
			await _unitOfWork.CommitAsync();
			return entity;

		}

		public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
		{
			await _repository.AddRangeAsync(entities);
			await _unitOfWork.CommitAsync();
			return entities;
		}

		public async Task DeleteAsync(T entity)
		{
			_repository.Delete(entity);
			await _unitOfWork.CommitAsync();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _repository.GetAll().ToListAsync();
		}

		public async Task<T> GetById(int id)
		{
			return await _repository.GetById(id);

		}

		public async Task RemoveRangeAsync(IEnumerable<T> entities)
		{
			_repository.RemoveRange(entities);
			await _unitOfWork.CommitAsync();
		}

		public async Task UpdateAsync(T entity)
		{
			_repository.Update(entity);
			await _unitOfWork.CommitAsync();
		}

		public IQueryable<T> Where(Expression<Func<T, bool>> espression)
		{
			return _repository.Where(espression);
		}
	}
}
