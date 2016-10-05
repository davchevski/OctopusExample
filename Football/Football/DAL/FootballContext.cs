using Football.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Football.DAL
{
    public class FootballContext : DbContext
    {
        public FootballContext():base("Football")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
         
    }
}