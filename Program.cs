using System.Security.Cryptography;
using LINQ.DataSources;
using LINQ.Models;

var products = Source.ProductList;
var customers = Source.CustomerList;

var highestThreePrices = products.OrderBy(s => s.UnitPrice).Take(3);

var secondPage = products.Skip(5).Take(5);

var LowUnitPrice = products.OrderBy(s => s.UnitPrice).Where(s => s.UnitPrice < 25);

var AllSeaFoodCondition = products.Where(x => x.Category == "Seafood").Any(u => u.UnitsInStock > 0); // True

int[] ids = { 3, 9, 13, 18 };

// foreach (var item in LowUnitPrice)
// {
Console.WriteLine($"{AllSeaFoodCondition}");
// }