using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	public class GetBookByIdService(IRepositoryAsync<Book> repository) : IGetByIdBooksService
	{
		private readonly IRepositoryAsync<Book> Repository = repository;

		public async Task<Book> GetByIdBookAsync(Guid id)
		{
			return await Repository.GetById(id);
		}
	}
}
