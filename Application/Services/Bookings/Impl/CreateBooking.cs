using Application.Models.Bookings;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Bookings.Impl
{
	public class CreateBooking(IRepositoryAsync<Booking> bookingRepository, IRepositoryAsync<Copy> copyRepository) : ICreateBooking
	{
		private readonly IRepositoryAsync<Booking> BookingRepository = bookingRepository;
		private readonly IRepositoryAsync<Copy> CopyRepository = copyRepository;

		public Task<Booking> CreateBookingAsync(CreateBookingModel createBookingModel)
		{
			throw new NotImplementedException();
		}
	}
}
