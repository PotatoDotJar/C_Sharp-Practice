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
        [Key]
        public int Id { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string IdentificationNumber { get; set; }
        public int Mileage { get; set; }
    }
}