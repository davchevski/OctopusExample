using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string City { set; get; }
        public int Year { get; set; }


        public virtual IEnumerable<Player> Igraci { get; set; }
        public virtual IEnumerable<League> Leagues { get; set; }

    }
}