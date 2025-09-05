using Application.Models.Books;
using Application.Resources;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	public class UpdateBooksService : IUpdateBookService
	{
		private readonly IRepositoryAsync<Book> Repository;

		public UpdateBooksService(IRepositoryAsync<Book> repository)
		{
			Repository = repository;
		}

		public async Task<Book> UpdateBookAsync(UpdateBookModel updateBookModel)
		{
			Book book = await Repository.GetById(updateBookModel.BookId) ?? throw new Exception(ResourcesMessages.NotFoundBook);
			book.Update(updateBookModel.Title, updateBookModel.AuthorId, updateBookModel.Isbn, updateBookModel.YearCreated, updateBookModel.CategoryId);
			return await Repository.Update(book);
		}
	}
}
