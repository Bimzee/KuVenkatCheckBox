using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KuVenkatCheckBox.Models
{
    [MetadataType(typeof(EmployeeMetadat))]
    [DisplayColumn("FullName")]
    public partial class Employee
    {
    }

    public class EmployeeMetadat
    {
     
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Hired Date")]
        public string HireDate { get; set; }

        [DisplayFormat(NullDisplayText ="Gender Not specified")]
        public string Gender { get; set; }

        [ScaffoldColumn(true)]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.Url)]
        public string PersonalWebSite { get; set; }
    }
}