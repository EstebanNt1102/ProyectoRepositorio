using Application.Constanst;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Loans.Imp
{
	public class ReturnLoan(IRepositoryAsync<Loan> loanRepository, IRepositoryAsync<Copy> copyRepository) : IReturnLoan
	{
		private readonly IRepositoryAsync<Loan> LoanRepository = loanRepository;
		private readonly IRepositoryAsync<Copy> CopyRepository = copyRepository;

		public async Task<double> ReturnLoanAsync(Guid id)
		{
			Loan loan = await LoanRepository.GetById(id) ?? throw new Exception();
			Copy copy = await CopyRepository.GetById(loan.CopyId) ?? throw new Exception();
			copy.Available = true;
			await LoanRepository.Update(loan);
			if (DateTime.UtcNow <= loan.ReturnDate)
				return 0;
			else
				return LoanConstant.FINE;
		}
	}
}
