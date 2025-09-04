using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	public class FilterBookService(IRepositoryAsync<Book> repository) : IFilterBooksService
	{
		private readonly IRepositoryAsync<Book> Repository = repository;

		public async Task<IEnumerable<Book>> FilterAsync(string? title, Guid authorid, Guid categoryid)
		{
			IEnumerable<Book> books = await Repository.GetAll();
			if (books != null)
				return books.Where(it => it.Title == title && it.AuthorId == authorid && it.CategoryId == categoryid);
			return [];
		}
	}
}
