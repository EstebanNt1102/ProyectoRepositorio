using Domain.Entities;

namespace Application.Services.Books
{
	public interface IGetAllBookService
	{
		public Task<List<Book>> GetAllAsync();
	}
}
