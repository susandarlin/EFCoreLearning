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

//var getCustomersWithLimit = _dbContext.Customers
//    .Take(1)
//    .AsNoTracking();

//foreach (var customer in getCustomersWithLimit)
//{
//    Console.WriteLine($" Customer Name: {customer.FirstName} {customer.LastName}, Age: {customer.Age}" );
//}

//var getAddressesByLimit = _dbContext.Addresses
//    .Take(2)
//    .AsNoTracking();

//foreach (var address in getAddressesByLimit)
//{
//    Console.WriteLine($" Address: {address.HseId}");
//}

var custommersWithInclude = _dbContext.Customers
    .Include(c => c.AddressCustomers)
        .ThenInclude(ca => ca.Address)
    .OrderByDescending(c => c.Age)
    .AsNoTracking();

foreach (var customer in custommersWithInclude)
{
    Console.WriteLine(customer);
    Console.WriteLine(customer.AddressCustomers.Select(ca => ca.Address));
}

Console.WriteLine("Press any key to exit");
Console.Read();
