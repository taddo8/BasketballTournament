using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasketballTournament.Models
{
    public class DivisionViewModel
    {
        public int Id { get; set; }
        public IEnumerable<DivisionType> DivisionTypes { get; set; }


        public Division Division { get; set; }
    }
}