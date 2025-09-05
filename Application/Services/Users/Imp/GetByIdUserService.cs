using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Users.Imp
{
	public class GetByIdUserService(IRepositoryAsync<User> repository) : IGetByIdUserService
	{
		private readonly IRepositoryAsync<User> Repository = repository;
		public async Task<User> GetByIdAsync(Guid id)
		{
			return await Repository.GetById(id);
		}
	}
}
