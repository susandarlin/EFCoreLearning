// See https://aka.ms/new-console-template for more information
using EFCoreLearning.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var _dbContext = new AppDbContext();

// Fetch all customers

//var customers = _dbContext.Customers
//    .OrderByDescending(c => c.Age)
//    .ToList();

//var customersQuerySyntax = from c in _dbContext.Customers
//                           orderby c.Age descending
//                           select c;

var getCustomersWithLimit = _dbContext.Customers
    .Take(1)
    .AsNoTracking();

foreach (var customer in getCustomersWithLimit)
{
    Console.WriteLine($" Customer Name: {customer.FirstName} {customer.LastName}, Age: {customer.Age}" );
}

Console.WriteLine("Press any key to exit");
Console.Read();
