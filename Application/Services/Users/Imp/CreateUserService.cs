using Application.Models.Users;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Users.Imp
{
	public class CreateUserService(IRepositoryAsync<User>repository) : ICreateUserService
	{
		private readonly IRepositoryAsync<User> Repository = repository;
		public async Task<User> CreateUsersAsync(CreateUserModel createUserModel)
		{
			User user = User.Create(Guid.NewGuid(), createUserModel.Name, createUserModel.Email, createUserModel.Role);
			return await Repository.Insert(user);
		}
	}
}
