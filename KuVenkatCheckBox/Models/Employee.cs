namespace KuVenkatCheckBox.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        public int? Age { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public int? Salary { get; set; }

        [StringLength(100)]
        public string PersonalWebSite { get; set; }
    }
}
