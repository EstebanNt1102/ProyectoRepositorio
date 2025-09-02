using Domain.Enums;

namespace Domain.Entities
{
	public class User
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public UserRole Role { get; set; }
		public ICollection<Loan> Loans { get; set; } = [];
		public ICollection<Booking> Bookings { get; set; } = [];


		public static User Create(Guid id, string? name, string? email, UserRole userRole)
		{
			return new User()
			{
				Id = id,
				Name = name,
				Email = email,
				Role = userRole
			};
		}

		public void Update(string? name, string? email, UserRole userRole)
		{
			Name = name;
			Email = email;
			Role = userRole;
		}
	}
}
