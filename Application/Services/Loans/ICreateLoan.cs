using Application.Models.Loans;
using Domain.Entities;

namespace Application.Services.Loans
{
	public interface ICreateLoan
	{
		public Task<Loan> CreateLoansAsync(CreateLoanModel createLoanModel);
	}
}
