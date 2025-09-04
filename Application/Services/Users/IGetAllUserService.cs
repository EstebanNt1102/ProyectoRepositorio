using Domain.Entities;

namespace Application.Services.Users
{
	public interface IGetAllUserService
	{
		public Task<List<User>> GetAllAsync();
	}
}
