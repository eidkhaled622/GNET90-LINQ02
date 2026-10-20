using LINQ.DataSources;
using LINQ.Models;

var products = Source.ProductList;
var customers = Source.CustomerList;

var highestThreePrices = products.OrderBy(s => s.UnitPrice).Take(3);

foreach (var product in highestThreePrices)
{
    Console.WriteLine($"{product.ProductName} , {product.UnitPrice}");
}