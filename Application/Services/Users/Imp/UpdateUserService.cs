using Application.Models.Users;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Users.Imp
{
	public class UpdateUserService(IRepositoryAsync<User> repository) : IUpdateUserService
	{
		private readonly IRepositoryAsync<User> Repository = repository;

		public async Task<User> UpdateUserAsync(UpdateUserModel updateUserModel)
		{
			Domain.Entities.User user = await Repository.GetById(updateUserModel.UserId) ?? throw new Exception();
			user.Update(user.Name, user.Email, user.Role);
			return await Repository.Insert(user);
		}
	}
}
