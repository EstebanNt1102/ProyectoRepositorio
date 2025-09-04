using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Loans.Imp
{
	internal class GetAllLoan : IGetAllLoan
	{
		private readonly IRepositoryAsync<Loan> Repositoy;
		public GetAllLoan(IRepositoryAsync<Loan>repository)
		{
			Repositoy = repository;
		}

		public async Task<List<Loan>> GetAllLoanAsync()
		{
			return (await Repositoy.GetAll()).ToList();
		}
	}
}
