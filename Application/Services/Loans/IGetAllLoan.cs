using Domain.Entities;

namespace Application.Services.Loans
{
	public interface IGetAllLoan
	{
		public Task<List<Loan>> GetAllLoanAsync();
	}
}
