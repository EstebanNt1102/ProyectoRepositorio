namespace Application.Models.Books
{
	public class CreateBookModel
	{
		public string? Title { get; set; }
		public Guid AuthorId { get; set; }
		public string? Isbn { get; set; }
		public int YearCreated { get; set; }
		public Guid CategoryId { get; set; }
	}
}
