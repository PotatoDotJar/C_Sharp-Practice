using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DotNetFrameworkRefresh.Models
{
    [Table("services")]
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int? CarId { get; set; }
        public virtual Car Car { get; set; }

        [Required]
        [Display(Name = "Service Date & Time")]
        public DateTime? ServiceDateTime { get; set; }

        [Required]
        [Display(Name = "Service Duration (hours)")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal? ServiceHours { get; set; }

        [Required]
        [Display(Name = "Service Notes")]
        public string ServiceNotes { get; set; }


    }
}