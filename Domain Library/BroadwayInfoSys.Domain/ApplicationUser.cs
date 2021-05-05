﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BroadwayInfoSys.Domain
{
    [Table("ApplicationUser")]
    public class ApplicationUser
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("Username")]
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("Password")]
        [Required]
        public string Password { get; set; }

        [Column("EntryDate")]
        [Required]
        public string EntryDate { get; set; }


    }
}
