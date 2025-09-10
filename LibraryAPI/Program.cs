using Application.Services.Bookings;
using Application.Services.Bookings.Impl;
using Application.Services.Books;
using Application.Services.Books.Imp;
using Application.Services.Loans;
using Application.Services.Loans.Imp;
using Application.Services.Users;
using Application.Services.Users.Imp;
using Domain.Patters;
using Infrastructure.Context;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<BookContext>(options =>
	options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Infrastructure")));
// Add services to the container.
builder.Services.AddScoped(typeof(IRepositoryAsync<>), typeof(EFRepository<>));
builder.Services.AddScoped<IAddCopiesAvailableService, AddCopiesAvailablesService>();
builder.Services.AddScoped<ICreateBookService, CreateBookService>();
builder.Services.AddScoped<IDecreaseCopies, DecreaseCopiesAvailableService>();
builder.Services.AddScoped<IDeleteBookService, DeleteBooksService>();
builder.Services.AddScoped<IFilterBooksService, FilterBookService>();
builder.Services.AddScoped<IGetAllBookService, GetAllBooksService>();
builder.Services.AddScoped<IGetByIdBooksService, GetBookByIdService>();
builder.Services.AddScoped<IUpdateBookService, UpdateBooksService>();
builder.Services.AddScoped<ICreateBooking, CreateBooking>();
builder.Services.AddScoped<ICreateLoan, CreateLoan>();
builder.Services.AddScoped<IGetAllLoan, GetAllLoan>();
builder.Services.AddScoped<IGetByIdLoan, GetByIdLoan>();
builder.Services.AddScoped<IReturnLoan, ReturnLoan>();
builder.Services.AddScoped<ICreateUserService, CreateUserService>();
builder.Services.AddScoped<IDeleteUserService, DeleteUserService>();
builder.Services.AddScoped<IFilterUserService, FilterUserService>();
builder.Services.AddScoped<IGetAllUserService, GetAllUserService>();
builder.Services.AddScoped<IGetByIdUserService, GetByIdUserService>();
builder.Services.AddScoped<IUpdateUserService, UpdateUserService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
