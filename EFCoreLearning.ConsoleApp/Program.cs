﻿// See https://aka.ms/new-console-template for more information
using EFCoreLearning.DataAccess.Models;

Console.WriteLine("Hello, World!");

var _dbContext = new AppDbContext();

// Fetch all customers

var customers = _dbContext.Customers
    .OrderByDescending(c => c.Age)
    .ToList();

Console.WriteLine("Press any key to exit");
Console.Read();
