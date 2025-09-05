using Application.Models.Books;
using Application.Resources;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	public class CreateBookService(IRepositoryAsync<Book> repository, IRepositoryAsync<Author> authorRepository,
		IRepositoryAsync<Category> categoryRepository) : ICreateBookService
	{
		private readonly IRepositoryAsync<Book> Repository = repository;
		private readonly IRepositoryAsync<Author> AuthorRepository = authorRepository;
		private readonly IRepositoryAsync<Category> CategoryRepository = categoryRepository;
		public async Task<Book> CreateBookAsync(CreateBookModel createBookModel)
		{
			Author author = await AuthorRepository.GetById(createBookModel.AuthorId) ?? throw new Exception(ResourcesMessages.NotFoundAuthor);

			Category category = await CategoryRepository.GetById(createBookModel.CategoryId) ?? throw new Exception(ResourcesMessages.NotFoundCategory);

			Book book = Book.Create(Guid.NewGuid(), createBookModel.Title, createBookModel.AuthorId, createBookModel.Isbn, createBookModel.YearCreated, createBookModel.CategoryId);
			return await Repository.Insert(book);
		}
	}
}
