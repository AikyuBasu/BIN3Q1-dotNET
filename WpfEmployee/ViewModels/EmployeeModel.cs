using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    public class EmployeeModel
    {
        private readonly Employee _employee;

        public EmployeeModel(Employee employee)
        {
            _employee = employee;
        }

        public DateTime? BirthDate
        {
            get { return _employee.BirthDate; }
        }

        public String FullName
        {
            get { return _employee.FirstName + " " + _employee.LastName; }
        }

        public String DisplayBirthDate
        {
            get { return _employee.BirthDate.ToString(); }
        }
    }

    

    
}
