using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class StadesViewModel : EntityModels
    {
        [Required]
        [Display(Name = "NbPlaces")]
        public int NbPlaces { get; set; }

        [Required]
        [Display(Name = "Planete")]
        public string Planete { get; set; }

    }
}