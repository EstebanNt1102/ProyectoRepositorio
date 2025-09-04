using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Users.Imp
{
	public class GetAllUserService(IRepositoryAsync<User> repository) : IGetAllUserService
	{
		private readonly IRepositoryAsync<User> Repository  = repository;
		public async Task<List<User>> GetAllAsync()
		{
			return (await Repository.GetAll()).ToList();
		}
	}
}
