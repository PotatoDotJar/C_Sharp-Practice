using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DotNetFrameworkRefresh.Models
{
    [Table("cars")]
    public class Car
    {
        public Car()
        {
            this.Services = new HashSet<Service>();
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Vehicle Make")]
        public string Make { get; set; }

        [Display(Name = "Vehicle Model")]
        public string Model { get; set; }

        [Display(Name = "VIN")]
        public string IdentificationNumber { get; set; }

        [Display(Name = "Mileage")]
        public int Mileage { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}