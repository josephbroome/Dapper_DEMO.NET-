using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using Dapper_DEMO.NET_;

IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

var repo = new DepartmentRepository(conn);

var productrepo = new ProductRepository(conn);

repo.InsertDepartment("My new Department!");

var departments = repo.GetAllDepartments();

foreach (var department in departments)
{
    Console.WriteLine(department.Name);
    Console.WriteLine(department.DepartmentID);
    Console.WriteLine();
    Console.WriteLine();
}

var products= productrepo.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine($"${product.Price}");
    Console.WriteLine(product.ProductID);
    Console.WriteLine();
    Console.WriteLine();
}



