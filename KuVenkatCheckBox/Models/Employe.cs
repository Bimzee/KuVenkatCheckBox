using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

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

        //[ScaffoldColumn(false)]
        [HiddenInput(DisplayValue =false)]
        public int Id { get; set; }

        [ReadOnly(true)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.Url)]
        [UIHint("UrlTemplate")]
        public string PersonalWebSite { get; set; }
    }
}