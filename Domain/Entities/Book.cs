namespace Domain.Entities
{
	public class Book
	{
		public Guid Id { get; set; }
		public string? Title { get; set; }
		public Guid AuthorId { get; set; }
		public virtual Author? Author { get; set; }
		public string? Isbn { get; set; }
		public int YearCreated { get; set; }
		public Guid CategoryId { get; set; }
		public virtual Category? Category { get; set; }
		public virtual ICollection<Copy> Copies { get; set; } = [];


		public static Book Create(Guid id, string? title, Guid authorId, string? isbn, int yearCreated, Guid categoryId)
		{
			return new Book()
			{
				Id = id,
				Title = title,
				AuthorId = authorId,
				Isbn = isbn,
				YearCreated = yearCreated,
				CategoryId = categoryId
			};
		}

		public void Update(string? title, Guid authorId, string? isbn, int yearCreated, Guid categoryId)
		{
			Title = title;
			AuthorId = authorId;
			Isbn = isbn;
			YearCreated = yearCreated;
			CategoryId = categoryId;
		}
	}
}
