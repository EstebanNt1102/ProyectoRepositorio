using Domain.Patters;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
	public class EFRepository<T> : IRepositoryAsync<T> where T : class
	{
		protected readonly BookContext _dbContext;
		private readonly DbSet<T> _dbSet;

		public EFRepository(BookContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<T>();
		}

		public async Task<T> GetById(Guid id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> Insert(T entity)
		{
			await _dbSet.AddAsync(entity);
			await _dbContext.SaveChangesAsync();
			return entity;
		}

		public async Task<T> Update(T entity)
		{
			_dbSet.Update(entity);
			await _dbContext.SaveChangesAsync();
			return entity;
		}

		public async Task Delete(Guid id)
		{
			T entity = await _dbSet.FindAsync(id);
			_dbSet.Remove(entity);
			await _dbContext.SaveChangesAsync();
		}
	}
}
