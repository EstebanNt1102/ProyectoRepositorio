using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	public class DeleteBooksService(IRepositoryAsync<Book> repository) : IDeleteBookService
	{
		private readonly IRepositoryAsync<Book> Repository = repository;

		public async Task DeleteBookAsync(Guid id)
		{
			await Repository.Delete(id);
		}
	}
}
