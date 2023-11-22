using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;


// tous les noms trouvées dans le binding view doivent se retrouver ici
namespace WpfEmployee.ViewModels
{
    public class EmployeeVM
    {
        private List<EmployeeModel> _employeesList;
        private NorthwindContext context = new NorthwindContext();

        private List<EmployeeModel> loadEmployees()
        {
            List<EmployeeModel> localCollection = new List<EmployeeModel>();
            foreach (var item in context.Employees)
            {
                localCollection.Add(new EmployeeModel(item));

            }

            return localCollection;

        }

        public List<EmployeeModel> EmployeesList
        {
            get {
                //if (_legumesList == null) _legumesList = loadLegumes2();
                //return _legumesList;
                return _employeesList = _employeesList ?? loadEmployees();
            }
        }
    }

    
}
