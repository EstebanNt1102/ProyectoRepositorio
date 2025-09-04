using Application.Models.Users;
using Domain.Entities;

namespace Application.Services.Users
{
	public interface ICreateUserService
	{
		public Task<User> CreateUsersAsync(CreateUserModel createUserModel);
	}
}
