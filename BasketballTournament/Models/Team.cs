using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasketballTournament.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Team's Name is required")]
        [StringLength(100)]
        public string TeamName { get; set; }

        [Required(ErrorMessage ="PhoneNumber is required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        public Division Division { get; set; }
    }
}