using Domain.Entities;
using Domain.Enums;

namespace Application.Services.Users
{
	public interface IFilterUserService
	{
		Task<IEnumerable<User>> FilterAsync(UserRole userRole);
	}
}
