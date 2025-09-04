namespace Application.Services.Users
{
	public interface IDeleteUserService
	{
		public Task DeleteUserAsync(Guid id);
	}
}
