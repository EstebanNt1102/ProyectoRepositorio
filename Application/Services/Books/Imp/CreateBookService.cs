using Application.Models.Books;
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
			Author author = await AuthorRepository.GetById(createBookModel.AuthorId) ?? throw new Exception();

			Category category = await CategoryRepository.GetById(createBookModel.CategoryId) ?? throw new Exception();

			Book book = Book.Create(Guid.NewGuid(), createBookModel.Title, createBookModel.AuthorId, createBookModel.Isbn, createBookModel.YearCreated, createBookModel.CategoryId);
			return await Repository.Insert(book);
		}

	}
}
