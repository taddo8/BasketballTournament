using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasketballTournament.Models
{
    public class Division
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Team Name")]
        public string Name { get; set; }

        [Display(Name="Division Type")]
        public DivisionType DivisionType { get; set; }

        [Display(Name="Time Slots")]
        public string TimeSlots { get; set; }
    }
}