using System.Text.Json.Serialization;

namespace Domain.Entities
{
	public class Author
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		[JsonIgnore]
		public virtual ICollection<Book> Books { get; set; } = new List<Book>();
	}
}
