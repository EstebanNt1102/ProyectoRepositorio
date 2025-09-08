using Application.Models.Loans;
using Application.Services.Loans;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;


namespace LibraryAPI.Controllers
{
	[Route("api/loan")]
	[ApiController]
	public class LoanController(ICreateLoan createLoan, IGetAllLoan getAllLoan, IGetByIdLoan getByIdLoan, IReturnLoan returnLoan)
	{
		private readonly ICreateLoan CreateLoan = createLoan;
		private readonly IGetAllLoan GetAllLoan = getAllLoan;
		private readonly IGetByIdLoan GetByIdLoan = getByIdLoan;
		private readonly IReturnLoan ReturnLoan = returnLoan;

		[HttpPost]
		public async Task<Loan> CreateLoansAsync(CreateLoanModel createLoanModel)
		{
			Loan createLoan = await CreateLoan.CreateLoansAsync(createLoanModel);
			return createLoan;
		}

		[HttpGet]
		public async Task<List<Loan>> GetAllAsync()
		{
			List<Loan> getAll = await GetAllLoan.GetAllLoanAsync();
			return getAll;
		}

		[HttpGet("{id}")]
		public async Task<Loan> GetByIdLoanAsync(Guid id)
		{
			Loan loan = await GetByIdLoan.GetByIdLoanAsync(id);
			return loan;
		}

		[HttpPut]
		public async Task<double> ReturnAsync(Guid id)
		{
			return await ReturnLoan.ReturnLoanAsync(id);
		}
	}
}
