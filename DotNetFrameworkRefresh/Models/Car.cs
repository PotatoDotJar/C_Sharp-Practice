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

        [Required]
        [Display(Name = "Vehicle Make")]
        public string Make { get; set; }

        [Required]
        [Display(Name = "Vehicle Model")]
        public string Model { get; set; }

        [Required]
        [Display(Name = "VIN")]
        public string IdentificationNumber { get; set; }

        [Required]
        [Display(Name = "Mileage")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public int? Mileage { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}