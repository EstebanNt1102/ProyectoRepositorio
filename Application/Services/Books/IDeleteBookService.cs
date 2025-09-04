namespace Application.Services.Books
{
	public interface IDeleteBookService
	{
		public Task DeleteBookAsync(Guid id);
	}
}
