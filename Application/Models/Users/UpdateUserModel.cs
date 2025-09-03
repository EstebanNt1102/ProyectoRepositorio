using Domain.Enums;

namespace Application.Models.Users
{
	public class UpdateUserModel
	{
		public Guid UserId { get; set; }
		public string? Name { get; set; }
		public string? Email { get; set; }
		public UserRole Role { get; set; }
	}
}
