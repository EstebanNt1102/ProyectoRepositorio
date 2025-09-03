namespace Application.Models.Books
{
	public class FilterBookModel
	{
		public string? Title { get; set; }
		public Guid? AuthorId { get; set; }
		public Guid CategoryId { get; set; }
	}
}
