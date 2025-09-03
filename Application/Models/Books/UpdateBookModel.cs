namespace Application.Models.Books
{
	public class UpdateBookModel
	{
		public Guid BookId { get; set; }
		public string? Title { get; set; }
		public Guid AuthorId { get; set; }
		public string? Isbn { get; set; }
		public int YearCreated { get; set; }
		public Guid CategoryId { get; set; }
	}
}
