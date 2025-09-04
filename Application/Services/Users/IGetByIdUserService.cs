using Domain.Entities;

namespace Application.Services.Users
{
	public interface IGetByIdUserService
	{
		public Task<User> GetByIdAsync(Guid id);
	}
}
