using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class JediViewModel : EntityModels
    {
        [Required]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "IsSith")]
        public bool IsSith { get; set; }
    }
}