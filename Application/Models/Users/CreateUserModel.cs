using Domain.Enums;

namespace Application.Models.Users
{
	public class CreateUserModel
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public UserRole Role { get; set; }
	}
}
