using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	public class GetAllBooksService(IRepositoryAsync<Book> repository) : IGetAllBookService
	{
		private readonly IRepositoryAsync<Book> Repository = repository;

		public async Task<List<Book>> GetAllAsync()
		{
			return (await Repository.GetAll()).ToList();
		}
	}
}
