using Application.Models.Books;
using Domain.Entities;

namespace Application.Services.Books
{
	public interface IAddCopiesAvailableService
	{
		public Task<Book> CopiesAvalableAsync(AddCopiesAvailabeModel addCopiesAvailabeModel);
	}
}
