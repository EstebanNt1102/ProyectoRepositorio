namespace Domain.Patters
{
	public interface IRepositoryAsync<T> where T : class
	{
		Task<IEnumerable<T>> GetAll();
		Task<T> GetById(Guid id);
		Task<T> Insert(T entity);
		Task<T> Update(T entity);
		Task Delete(Guid id);
	}
}
