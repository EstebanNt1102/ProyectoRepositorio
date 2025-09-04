using Domain.Entities;

namespace Application.Services.Loans
{
	public interface IGetByIdLoan
	{
		public Task<Loan> GetByIdLoanAsync(Guid id);
	}
}
