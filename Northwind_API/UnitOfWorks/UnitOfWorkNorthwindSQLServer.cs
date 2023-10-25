using Northwind_API.Models;
using Northwind_API.Repositories;

namespace Northwind_API.UnitOfWorks
{
    public class UnitOfWorkNorthwindSQLServer : IUnitOfWorkNorthwind
    {
        private readonly NorthwindContext _context;

        private EmployeesRepositorySQL _employeesRepository;

        private OrdersRepositorySQL _ordersRepository;


        public UnitOfWorkNorthwindSQLServer(NorthwindContext context)
        {
            this._context = context;
            this._employeesRepository = new EmployeesRepositorySQL(context);
            this._ordersRepository = new OrdersRepositorySQL(context);
        }

        public IRepository<Employee> EmployeesRepository
        {
            get { return this._employeesRepository; }
        }

        public IRepository<Order> OrdersRepository
        {
            get { return this._ordersRepository; }
        }

    }
}
