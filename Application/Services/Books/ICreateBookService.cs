using Application.Models.Books;
using Domain.Entities;

namespace Application.Services.Books
{
	public interface ICreateBookService
	{
		public Task<Book> CreateBookAsync(CreateBookModel createBookModel);
	}
}
