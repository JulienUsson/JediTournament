using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class EntityModels
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
    }
}