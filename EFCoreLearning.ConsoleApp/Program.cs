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

//var custommersWithInclude = _dbContext.Customers
//    .Include(c => c.AddressCustomers)
//        .ThenInclude(ca => ca.Address)
//    .OrderByDescending(c => c.Age)
//    .AsNoTracking();

//foreach (var customer in custommersWithInclude)
//{
//    Console.WriteLine(customer.FirstName);
//    Console.WriteLine(string.Join(", ", customer.AddressCustomers.Select(ca => ca.AddressId)));
//}

// Simple SelectMany
//var AddressCustomers = _dbContext.Customers.AsNoTracking()
//    .Include(c => c.AddressCustomers)
//        .ThenInclude(ca => ca.Address)
//    .SelectMany(c => c.AddressCustomers)
//    .ToList();

//foreach (var addressCustomer in AddressCustomers)
//{
//    Console.WriteLine(addressCustomer.Address.HseId);
//}

// SelectMany with projection

//var customerAddressData = _dbContext.Customers.AsNoTracking()
//    .Include(c => c.AddressCustomers)
//            .ThenInclude(ca => ca.Address)
//    .SelectMany(c => c.AddressCustomers, (customer, customerAddress) => new
//    {
//        FirstName = customer.FirstName,
//        LastName = customer.LastName,
//        addressName = customerAddress.Address.HseId
//    });

//foreach (var customerAddress in customerAddressData)
//{
//    Console.WriteLine(customerAddress);
//}

// SelectMany with projection and distinct

var distinctZipCode = _dbContext.Customers.AsNoTracking()
    .Include(c=> c.AddressCustomers)
        .ThenInclude(ca => ca.Address)
    .SelectMany(c=>c.AddressCustomers.Select(a=> a.Address.ZipCd))
    .Distinct();

foreach (var zipCode in distinctZipCode)
{
    Console.WriteLine(zipCode);
}

Console.WriteLine("Press any key to exit");
Console.Read();
