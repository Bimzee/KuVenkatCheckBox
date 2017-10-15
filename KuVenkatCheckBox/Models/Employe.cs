﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KuVenkatCheckBox.Models
{
    [MetadataType(typeof(EmployeeMetadat))]
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

        [ScaffoldColumn(false)]
        public int Salary { get; set; }

        [ScaffoldColumn(false)]
        public int Id { get; set; }
    }
}