using System.Text.Json.Serialization;

namespace Domain.Entities
{
	public class Copy(Guid bookId)
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid BookId { get; set; } = bookId;
		[JsonIgnore]
		public virtual Book? Book { get; set; }
		public bool Available { get; set; } = true;
		[JsonIgnore]
		public virtual ICollection<Loan> Loans { get; set; } = [];
		[JsonIgnore]
		public virtual ICollection<Booking> Bookings { get; set; } = [];
	}
}
