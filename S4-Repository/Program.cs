using Microsoft.IdentityModel.Tokens;
using SchoolApp.Models;
using SchoolApp.Repository;

Console.WriteLine("Hello BLYAT");


SchoolContext ctx = new SchoolContext();

SchoolBaseRepository<Section> repositorySection = new SchoolBaseRepository<Section>(ctx);

Console.WriteLine("Inserting 2 new Sections : name sectInfo & sectDiet");

if (repositorySection.SearchFor(e => e.Name == "sectInfo").IsNullOrEmpty())
{
    repositorySection.Insert(new Section { Name = "sectInfo" });
    Console.WriteLine("sectInfo added.");
} else
{
    Console.WriteLine("sectInfo already exists.");
}

if (repositorySection.SearchFor(e => e.Name == "sectDiet").IsNullOrEmpty())
{
    repositorySection.Insert(new Section { Name = "sectDiet" });
    Console.WriteLine("sectDiet added.");
}
else
{
    Console.WriteLine("sectDiet already exists.");
}

IQueryable<Section> sections = (from s in ctx.Sections select s);

foreach (var s in sections)
{
    Console.WriteLine("Section Name : " + s.Name);
}



