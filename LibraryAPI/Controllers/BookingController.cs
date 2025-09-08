using Application.Models.Bookings;
using Application.Services.Bookings;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
	[Route("api/booking")]
	[ApiController]
	public class BookingController(ICreateBooking createBooking) : ControllerBase
	{
		private readonly ICreateBooking CreateBooking = createBooking;

		[HttpPost]
		public async Task<Booking> CreateBookingAsync(CreateBookingModel createBookingModel)
		{
			Booking createBooking = await CreateBooking.CreateBookingAsync(createBookingModel);
			return createBooking;
		}
	}
}
