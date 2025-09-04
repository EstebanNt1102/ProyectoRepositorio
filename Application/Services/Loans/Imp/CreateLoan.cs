using Application.Constanst;
using Application.Models.Loans;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Loans.Imp
{
	public class CreateLoan(IRepositoryAsync<Loan> repository, IRepositoryAsync<Copy> copyRepository) : ICreateLoan
	{
		private readonly IRepositoryAsync<Loan> Repository = repository;
		private readonly IRepositoryAsync<Copy> CopyRepository = copyRepository;

		public async Task<Loan> CreateLoansAsync(CreateLoanModel createLoanModel)
		{
			Copy copy = await CopyRepository.GetById(createLoanModel.CopyId) ?? throw new Exception();
			if (copy.Available == false)
				throw new Exception();
			copy.Available = false;
			await CopyRepository.Update(copy);
			DateTime currentDay = DateTime.UtcNow;
			Loan loan = Loan.Create(Guid.NewGuid(), createLoanModel.CopyId, createLoanModel.UserId, currentDay, currentDay.AddDays(LoanConstant.RETURN_DAYS));
			await Repository.Insert(loan);
			return loan;
		}
	}
}
