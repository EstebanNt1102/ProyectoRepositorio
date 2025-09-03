using Application.Models.Bookings;
using Domain.Entities;

namespace Application.Services.Bookings
{
	public interface ICreateBooking
	{
		public Task<Booking> CreateBookingAsync(CreateBookingModel createBookingModel);
	}
}
