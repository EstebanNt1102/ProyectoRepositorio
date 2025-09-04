using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Loans.Imp
{
	internal class GetByIdLoan : IGetByIdLoan
	{
		private readonly IRepositoryAsync<Loan> Repository;

		public GetByIdLoan(IRepositoryAsync<Loan> repository)
		{
			Repository = repository;
		}

		public async Task<Loan> GetByIdLoanAsync(Guid id)
		{
			return await Repository.GetById(id);
		}
	}
}
