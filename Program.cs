using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using LINQ.DataSources;
using LINQ.Models;

var products = Source.ProductList;
var customers = Source.CustomerList;

var highestThreePrices = products.OrderBy(s => s.UnitPrice).Take(3);

var secondPage = products.Skip(5).Take(5);

var LowUnitPrice = products.OrderBy(s => s.UnitPrice).Where(s => s.UnitPrice < 25);

var AllSeaFoodCondition = products.Where(x => x.Category == "Seafood").Any(u => u.UnitsInStock > 0); // True

int[] ids = { 3, 9, 13, 18 };

var isContainsNine = ids.Contains(9);

var CountCategory = products.GroupBy(x => x.Category);

var NamesOnCategory = products.GroupBy(x => x.Category);

var CategoriesProduct = products.GroupBy(x => x.Category)
    .Where(c => c.Select(p => p.ProductName).Distinct().Count() > 3);

var CustomerCountry =
    from customer in customers
    group customer by customer.Country into g
    select new
    {
        Country = g.Key,
        Count = g.Count(),
        TotalOrderValue = g.Sum(s => s.Orders.Sum(sub => sub.Total))
    };

var getTheTotalItemsInStock = products.Sum(p => p.UnitsInStock);

// foreach (var item in CustomerCountry)
// {
Console.WriteLine($"{getTheTotalItemsInStock}");
// }