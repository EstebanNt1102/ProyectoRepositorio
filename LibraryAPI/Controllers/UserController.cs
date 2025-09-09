using Application.Models.Users;
using Application.Services.Users;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController(ICreateUserService createUser, IDeleteUserService deleteUser, IFilterUserService filterUser,
		IGetAllUserService getAllUser, IGetByIdUserService getByIdUser, IUpdateUserService updateUser)
	{
		private readonly ICreateUserService CreateUser = createUser;
		private readonly IDeleteUserService DeleteUser = deleteUser;
		private readonly IFilterUserService FilterUserService = filterUser;
		private readonly IGetAllUserService GetAllUserService = getAllUser;
		private readonly IGetByIdUserService GetByIdUserService = getByIdUser;
		private readonly IUpdateUserService UpdateUserService = updateUser;

		[HttpPost]
		public async Task<User> CreateUserAsync(CreateUserModel createUserModel)
		{
			User createUser = await CreateUser.CreateUsersAsync(createUserModel);
			return createUser;
		}

		[HttpGet]
		public async Task<List<User>> GetAllAsync()
		{
			List<User> getAll = await GetAllUserService.GetAllAsync();
			return getAll;
		}

		[HttpGet("{id}")]
		public async Task<User> GetByIdUserAsync(Guid id)
		{
			User user = await GetByIdUserService.GetByIdAsync(id);
			return user; 
		}

		[HttpGet("filter")]
		public async Task<List<User>> FilterAsync(UserRole userRole)
		{
			List<User> filter = [.. await FilterUserService.FilterAsync(userRole)];
			return filter;
		}

		[HttpPut]
		public async Task<User> UpdateAsync(UpdateUserModel updateUserModel)
		{
			User updateUser = await UpdateUserService.UpdateUserAsync(updateUserModel);
			return updateUser;
		}

		[HttpDelete]
		public async Task DeleteAsync(Guid id)
		{
			await DeleteUser.DeleteUserAsync(id);
		}
	}
}
