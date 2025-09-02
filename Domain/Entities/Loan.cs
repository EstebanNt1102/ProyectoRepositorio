namespace Domain.Entities
{
	public class Loan
	{
		public Guid Id { get; set; }
		public Guid CopyId { get; set; }
		public virtual Copy? Copy { get; set; }
		public Guid UserId { get; set; }
		public virtual User? User { get; set; }
		public DateTime? DateLoan { get; set; }
		public DateTime ReturnDate { get; set; }

		public static Loan Create(Guid id, Guid copyId, Guid userId, DateTime dateLoan, DateTime returnDate)
		{
			return new Loan()
			{
				Id = id,
				CopyId = copyId,
				UserId = userId,
				DateLoan = dateLoan,
				ReturnDate = returnDate
			};
		}
	}
}
