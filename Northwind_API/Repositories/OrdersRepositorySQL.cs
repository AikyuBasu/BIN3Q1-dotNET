using Northwind_API.Models;

namespace Northwind_API.Repositories
{
    public class OrdersRepositorySQL : BaseRepositorySQL<Order>
    {

        public OrdersRepositorySQL(NorthwindContext dbContext) : base(dbContext)
        {

        }
    }
}
