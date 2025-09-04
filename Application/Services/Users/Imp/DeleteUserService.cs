
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Users.Imp
{
	internal class DeleteUserService(IRepositoryAsync<User> repository) : IDeleteUserService
	{
		private readonly IRepositoryAsync<User> Repository = repository;
		public async Task DeleteUserAsync(Guid id)
		{
			await Repository.Delete(id);
		}
	}
}
