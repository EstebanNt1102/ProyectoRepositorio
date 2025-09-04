using Domain.Entities;

namespace Application.Services.Books
{
	public interface IFilterBooksService
	{
		Task<IEnumerable<Book>> FilterAsync(string? title, Guid authorid, Guid categoryid);
	}
}
