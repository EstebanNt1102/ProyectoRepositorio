using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
	public class BookContext : DbContext
	{
		public BookContext(DbContextOptions<BookContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Book> Books { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Loan> Loans { get; set; }
		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Booking> Bookings { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Copy> Copies { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<Book>()
				.Property(x => x.Title)
				.HasMaxLength(100)
				.IsRequired();

			modelBuilder.Entity<Book>()
				.Property(x => x.Isbn)
				.HasMaxLength(13)
				.IsRequired();

			modelBuilder.Entity<Book>()
				.Property(x => x.YearCreated)
				.IsRequired();

			modelBuilder.Entity<Book>()
				.HasOne(z => z.Author)
				.WithMany(z => z.Books).HasForeignKey(a => a.AuthorId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Book>()
				.HasOne(x => x.Category)
				.WithMany(x => x.Books).HasForeignKey(a => a.CategoryId);



			modelBuilder.Entity<User>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<User>()
				.Property(x => x.Name)
				.HasMaxLength(50)
				.IsRequired();

			modelBuilder.Entity<User>()
				.Property(x => x.Email)
				.HasMaxLength(100)
				.IsRequired();

			modelBuilder.Entity<User>()
				.Property(x => x.Role)
				.HasColumnType("varchar")
				.HasMaxLength(20);



			modelBuilder.Entity<Loan>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<Loan>()
				.Property(x => x.DateLoan)
				.IsRequired();

			modelBuilder.Entity<Loan>()
				.Property(x => x.ReturnDate)
				.IsRequired();

			modelBuilder.Entity<Loan>()
				.HasOne(z => z.Copy)
				.WithMany(z => z.Loans).HasForeignKey(a => a.CopyId);

			modelBuilder.Entity<Loan>()
				.HasOne(z => z.User)
				.WithMany(z => z.Loans).HasForeignKey(a => a.UserId);



			modelBuilder.Entity<Booking>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<Booking>()
				.Property(x => x.DateBooking)
				.IsRequired();

			modelBuilder.Entity<Booking>()
				.HasOne(z => z.User)
				.WithMany(z => z.Bookings).HasForeignKey(a => a.UserId);

			modelBuilder.Entity<Booking>()
				.HasOne(z => z.Copy)
				.WithMany(z => z.Bookings).HasForeignKey(a => a.CopyId);



			modelBuilder.Entity<Copy>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<Copy>()
				.Property(x => x.Available)
				.HasDefaultValue(true)
				.IsRequired();

			modelBuilder.Entity<Copy>()
				.HasOne(z => z.Book)
				.WithMany(z => z.Copies).HasForeignKey(a => a.BookId);


			modelBuilder.Entity<Author>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<Author>()
				.Property(x => x.Name)
				.HasMaxLength(50)
				.IsRequired();


			modelBuilder.Entity<Category>()
				.HasKey(x => x.Id);

			modelBuilder.Entity<Category>()
				.Property(x => x.Name)
				.HasMaxLength(50)
				.IsRequired();
		}
	}
}
