using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Models
{
    [Table("players")]
    public partial class Player
    {
        [Key]
        [Column("player_id")]
        public int PlayerId { get; set; }
        [Column("player_name")]
        [StringLength(255)]
        [Unicode(false)]
        public string? PlayerName { get; set; }

        [InverseProperty("ScoreNavigation")]
        public virtual Score? Score { get; set; }
        [InverseProperty("UserNavigation")]
        public virtual User? User { get; set; }
    }
}
