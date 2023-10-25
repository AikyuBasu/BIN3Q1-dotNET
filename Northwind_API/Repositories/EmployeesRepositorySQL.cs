

using Northwind_API.Models;
using Northwind_API.Repositories;

public class EmployeesRepositorySQL : BaseRepositorySQL<Employee>
{
    public EmployeesRepositorySQL(NorthwindContext dbContext) : base(dbContext)
    {

    }
}

