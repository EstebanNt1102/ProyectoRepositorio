using Application.Models.Books;
using Domain.Entities;

namespace Application.Services.Books
{
	public interface IUpdateBookService
	{
		public Task<Book> UpdateBookAsync(UpdateBookModel updateBookModel);
	}
}
