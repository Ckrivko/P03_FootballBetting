using P03_FootballBetting.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P03_FootballBetting.Data.Models
{
    public class Player
    {
        // PlayerId, Name, SquadNumber, TeamId, PositionId, IsInjured

        public Player()
        {
            this.PlayerStatistics = new HashSet<PlayerStatistic>();
        }

        [Key]
        public int PlayerId { get; set; }

        [Required]
        [MaxLength(GlobalConstants.PlayeNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public int SquadNumber { get; set; }


        //Do the player have team?
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }


        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        [Required]//?
        public bool IsInjured { get; set; }


        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }

    }

}
