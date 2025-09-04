using Domain.Entities;

namespace Application.Services.Books
{
	public interface IGetByIdBooksService
	{
		public Task<Book> GetByIdBookAsync(Guid id);
	}
}
