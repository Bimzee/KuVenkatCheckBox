using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KuVenkatCheckBox.Models
{
    public class Company
    {
        public Employee CompanyDirector {
            get
            {
                EmployeDataModel db = new EmployeDataModel();

                return db.Employees.Single(x => x.Id == 1);

            }
        }

    }
}