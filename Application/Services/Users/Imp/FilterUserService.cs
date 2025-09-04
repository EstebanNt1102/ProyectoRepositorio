using Domain.Entities;
using Domain.Enums;
using Domain.Patters;

namespace Application.Services.Users.Imp
{
	public class FilterUserService(IRepositoryAsync<User> repository) : IFilterUserService
	{
		private readonly IRepositoryAsync<User> Repository = repository;
		public async Task<IEnumerable<User>> FilterAsync(UserRole userRole)
		{
			IEnumerable<User> users = await Repository.GetAll();
			if (users != null) 
				return users.Where(x => x.Role == userRole);
			return [];
		}
	}
}
