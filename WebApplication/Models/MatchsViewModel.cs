using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication.WebService;

namespace WebApplication.Models
{
    public class MatchsViewModel : EntityModels
    {
        [Required]
        [Display(Name = "Vainqueur")]
        public JediContract Vainqueur { get; set; }

        [Required]
        [Display(Name = "Jedi1")]
        public JediContract Jedi1 { get; set; }

        [Required]
        [Display(Name = "Jedi2")]
        public JediContract Jedi2 { get; set; }

        [Required]
        [Display(Name = "PhaseTournoi")]
        public EPhaseTournoiContract PhaseTournoi { get; set; }

        [Required]
        [Display(Name = "Stade")]
        public StadeContract Stade { get; set; }
    }
}