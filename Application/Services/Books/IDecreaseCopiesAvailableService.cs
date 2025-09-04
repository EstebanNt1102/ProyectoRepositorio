using Application.Models.Books;

namespace Application.Services.Books
{
	public interface IDecreaseCopies
	{
		public Task<bool> DecreaseCopiesAsync(DecreaseCopieAvailableModel decreaseCopieAvailableModel);
	}
}
