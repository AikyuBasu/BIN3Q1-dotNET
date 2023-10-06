using ConsoleAppLINQToEntities.Models;

NorthwindContext context = new NorthwindContext();

Console.WriteLine("B1 - Recherche clients par ville\nEntrez le nom d'une ville : ");
string city = Console.ReadLine().Trim();


    IList<Customer> custs = (from c in context.Customers
                             where c.City == city
                             select c).ToList();

    Console.WriteLine("Matching customers: " + custs.Count);

    foreach (Customer customer in custs)
    {
        Console.WriteLine(customer.ContactName);
    }

Console.WriteLine("Exercice LazyLoading");
IList<Product> products = context.Products.ToList();


Console.WriteLine("Catégorie : Beverages");

foreach (Product p in products)
{
    if (p.Category?.CategoryName == "Beverages") Console.WriteLine(p.ProductName);
}

Console.WriteLine("Catégorie : Condiments");
foreach (Product p in products)
{
    if (p.Category?.CategoryName == "Condiments") Console.WriteLine(p.ProductName);
}