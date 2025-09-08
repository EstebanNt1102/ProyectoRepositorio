using Application.Models.Books;
using Application.Services.Books;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
	[Route("api/book")]
	[ApiController]
	public class BookController(IAddCopiesAvailableService addCopiesAvailable, ICreateBookService createBook, IDecreaseCopies decreaseCopies,
		IDeleteBookService deleteBook, IFilterBooksService filterBooks, IGetAllBookService getAllBook, IGetByIdBooksService getByIdBook, IUpdateBookService updateBook) : ControllerBase
	{
		private readonly IAddCopiesAvailableService AddCopiesAvailable = addCopiesAvailable;
		private readonly ICreateBookService CreateBook = createBook;
		private readonly IDeleteBookService DeleteBook = deleteBook;
		private readonly IFilterBooksService FilterBooks = filterBooks;
		private readonly IGetAllBookService GetAllBook = getAllBook;
		private readonly IGetByIdBooksService GetByIdBook = getByIdBook;
		private readonly IUpdateBookService UpdateBook = updateBook;
		private readonly IDecreaseCopies DecreaseCopies = decreaseCopies;

		[HttpPost]
		public async Task<Book> CreateAsync(CreateBookModel createBookModel)
		{
			Book createBook = await CreateBook.CreateBookAsync(createBookModel);
			return createBook;
		}

		[HttpGet]
		public async Task<List<Book>> GetAllAsync()
		{
			List<Book> getAll = await GetAllBook.GetAllAsync();
			return getAll;
		}

		[HttpGet("{id}")]
		public async Task<Book> GetBookIdAsync(Guid id)
		{
			Book book = await GetByIdBook.GetByIdBookAsync(id);
			return book;
		}

		[HttpGet("filter/{title}/{authorid}/{categoryid}")]
		public async Task<List<Book>> FilterAsync(string? title, Guid authorid, Guid categoryid)
		{
			List<Book> filter = [.. await FilterBooks.FilterAsync(title, authorid, categoryid)];
			return filter;
		}

		[HttpPut]
		public async Task<Book> UpdateAsync(UpdateBookModel updateBookModel)
		{
			Book updateBook = await UpdateBook.UpdateBookAsync(updateBookModel);
			return updateBook;
		}

		[HttpPut("addCopies")]
		public async Task<Book> AddCopiesAsync(AddCopiesAvailabeModel addCopiesAvailabeModel)
		{
			Book addCopies = await AddCopiesAvailable.CopiesAvalableAsync(addCopiesAvailabeModel);
			return addCopies;
		}

		[HttpPut("decreaseCopies")]
		public async Task<bool> DecreaseCopiesAsync(DecreaseCopieAvailableModel decreaseCopieAvailableModel)
		{
			bool decreaseCopies = await DecreaseCopies.DecreaseCopiesAsync(decreaseCopieAvailableModel);
			return decreaseCopies;
		}

		[HttpDelete]
		public async Task DeleteAsync(Guid id)
		{
			await DeleteBook.DeleteBookAsync(id);
		}
	}
}
