using Cqrs.Repositories;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Loans.Imp
{
	public class GetAllLoan : IGetAllLoan
	{
		private readonly IRepositoryAsync<Loan> Repository;
		public GetAllLoan(IRepositoryAsync<Loan>repository)
		{
			Repository = repository;
		}

		public async Task<List<Loan>> GetAllLoanAsync()
		{
			return (await Repository.GetAll()).ToList();
		}
	}
}
