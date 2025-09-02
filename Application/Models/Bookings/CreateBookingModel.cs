namespace Application.Models.Bookings
{
	public class CreateBookingModel
	{
		public Guid CopyId { get; set; }
		public Guid UserId { get; set; }
		public DateTime BookingDate { get; set; }
	}
}
