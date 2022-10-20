using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Models
{
    [Table("score")]
    public partial class Score
    {
        [Key]
        [Column("score_id")]
        public int ScoreId { get; set; }
        [Column("player_score")]
        public int? PlayerScore { get; set; }

        [ForeignKey("ScoreId")]
        [InverseProperty("Score")]
        public virtual Player ScoreNavigation { get; set; } = null!;
    }
}
