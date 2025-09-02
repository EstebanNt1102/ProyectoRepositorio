namespace Domain.Entities
{
	public class Booking(Guid id, Guid userId, Guid copyId, DateTime dateBooking)
	{
		public Guid Id { get; set; } = id;
		public Guid UserId { get; set; } = userId;
		public virtual User? User { get; set; }
		public Guid CopyId { get; set; } = copyId;
		public virtual Copy? Copy { get; set; }
		public DateTime DateBooking { get; set; } = dateBooking;
	}
}
