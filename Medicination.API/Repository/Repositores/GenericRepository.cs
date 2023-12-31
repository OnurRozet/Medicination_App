﻿using Medicination.API.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Medicination.API.Repository.Repositores
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class

	{

		protected readonly AppDbContext _context;

		private readonly DbSet<T> _dbSet;
		public GenericRepository(AppDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task AddRangeAsync(IEnumerable<T> entities)
		{
			await _dbSet.AddRangeAsync(entities);
		}

		public void Delete(T entity)
		{
			_dbSet.Remove(entity);
		}

		public IQueryable<T> GetAll()
		{
			return _dbSet.AsNoTracking().AsQueryable();
		}

		public async Task<T> GetById(string id)
		{
			return await _dbSet.FindAsync(id);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			_dbSet.RemoveRange(entities);
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);
		}

		public IQueryable<T> Where(Expression<Func<T, bool>> espression)
		{
			return _dbSet.Where(espression);
		}
	}
}
