using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Models
{
    [Table("users")]
    public partial class User
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("address")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Address { get; set; }
        [Column("email")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Email { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("User")]
        public virtual Player UserNavigation { get; set; } = null!;
    }
}
