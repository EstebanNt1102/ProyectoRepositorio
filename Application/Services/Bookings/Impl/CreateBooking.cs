using Application.Models.Bookings;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Bookings.Impl
{
	public class CreateBooking(IRepositoryAsync<Booking> bookingRepository, IRepositoryAsync<Copy> copyRepository) : ICreateBooking
	{
		private readonly IRepositoryAsync<Booking> BookingRepository = bookingRepository;
		private readonly IRepositoryAsync<Copy> CopyRepository = copyRepository;

		public async Task<Booking> CreateBookingAsync(CreateBookingModel createBookingModel)
		{
			Copy copy = await CopyRepository.GetById(createBookingModel.CopyId);
			if (copy.Available == false)
				throw new Exception();
			copy.Available = false;
			await CopyRepository.Update(copy);
			Booking booking = new(Guid.NewGuid(), createBookingModel.UserId, createBookingModel.CopyId, createBookingModel.BookingDate);
			await BookingRepository.Insert(booking);
			return booking;
		}
	}
}
