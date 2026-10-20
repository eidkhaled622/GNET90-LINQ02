using LINQ.DataSources;
using LINQ.Models;

var products = Source.ProductList;
var customers = Source.CustomerList;

var highestThreePrices = products.OrderBy(s => s.UnitPrice).Take(3);

var secondPage = products.Skip(5).Take(5);

foreach (var product in secondPage)
{
    Console.WriteLine($"{product.ProductID},{product.ProductName} , {product.UnitPrice}");
}