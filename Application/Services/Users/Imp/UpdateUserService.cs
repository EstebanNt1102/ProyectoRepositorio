using Application.Models.Users;
using Application.Resources;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Users.Imp
{
	public class UpdateUserService(IRepositoryAsync<User> repository) : IUpdateUserService
	{
		private readonly IRepositoryAsync<User> Repository = repository;

		public async Task<User> UpdateUserAsync(UpdateUserModel updateUserModel)
		{
			User user = await Repository.GetById(updateUserModel.UserId) ?? throw new Exception(ResourcesMessages.NotFoundUser);
			user.Update(user.Name, user.Email, user.Role);
			return await Repository.Insert(user);
		}
	}
}
