namespace Application.Services.Loans
{
	public interface IReturnLoan
	{
		public Task<double> ReturnLoanAsync(Guid id);
	}
}
