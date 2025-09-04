using Application.Models.Books;
using Domain.Entities;
using Domain.Patters;

namespace Application.Services.Books.Imp
{
	public class DecreaseCopiesAvailableService(IRepositoryAsync<Copy> repositoryCopy) : IDecreaseCopies
	{
		public async Task<bool> DecreaseCopiesAsync(DecreaseCopieAvailableModel decreaseCopieAvailableModel)
		{
			IEnumerable<Copy> allcopies = await repositoryCopy.GetAll();
			if (allcopies != null)
			{
				IEnumerable<Copy> bookCopies = allcopies.Where(it => it.BookId == decreaseCopieAvailableModel.Id);
				foreach (Copy copy in bookCopies)
				{
					if (decreaseCopieAvailableModel.CopiesId > 0)
						await repositoryCopy.Delete(copy.Id);
					else
						break;
					decreaseCopieAvailableModel.CopiesId--;
				}
				return true;
			}
			return false;
		}
	}
}
