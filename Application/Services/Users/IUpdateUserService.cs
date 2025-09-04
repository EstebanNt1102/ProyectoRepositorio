using Application.Models.Users;
using Domain.Entities;

namespace Application.Services.Users
{
	public interface IUpdateUserService
	{
		public Task<User> UpdateUserAsync(UpdateUserModel updateUserModel);
	}
}
