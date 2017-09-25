using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ahmed_Job.Models
{
    public class category
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [Display(Name= "نوع الوظيفه")]
        public String CategoryName { get; set; }


        [Required]
        [Display(Name ="وصف النوع")]
        public String CategoryDesc { get; set; }
    }
}