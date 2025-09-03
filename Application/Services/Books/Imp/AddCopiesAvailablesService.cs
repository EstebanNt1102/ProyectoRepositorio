using Application.Models.Books;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	internal class AddCopiesAvailablesService(IRepositoryAsync<Book>repository,  IRepositoryAsync<Copy> repositoryCopy) : IAddCopiesAvailableService
	{
		public async Task<Book> CopiesAvalableAsync(AddCopiesAvailabeModel addCopiesAvailabeModel)
		{
			Book book = await repository.GetById(addCopiesAvailabeModel.Id) ?? throw new Exception();
			for (int i = 0; i < addCopiesAvailabeModel.Copies; i++)
			{
				Copy copyToCreate = new(book.Id);
				await repositoryCopy.Insert(copyToCreate);
				book.Copies.Add(copyToCreate);
			}
			return book;
		}
	}
}
