using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class Player
    {
        public enum PlayerPosition
        {
            Goalkeeper=1,
            Defender=2,
            Midfilder=3,
            Striker=4
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Price { get; set; }
        public PlayerPosition Position { get; set; } 

        public int team_id { get; set; }

        [ForeignKey("team_id")]
        public virtual Team team { get; set; }
    }
}