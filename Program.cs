using LINQ.DataSources;
using LINQ.Models;

var products = Source.ProductList;
var customers = Source.CustomerList;

var highestThreePrices = products.OrderBy(s => s.UnitPrice).Take(3);

var secondPage = products.Skip(5).Take(5);

var LowUnitPrice = products.OrderBy(s => s.UnitPrice).Where(s => s.UnitPrice < 25);

foreach (var product in LowUnitPrice)
{
    Console.WriteLine($"{product.ProductID},{product.ProductName} , {product.UnitPrice}");
}