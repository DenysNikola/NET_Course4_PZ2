using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    public class UserAnimeList
    {
        [Key]
        public int ListID { get; set; }
        public int UserID { get; set; }
        public int AnimeID { get; set; }
        public string? Status { get; set; }
        public int? Score { get; set; }
        public DateTime? DateAdded { get; set; }

        // Navigation property for User
        [ForeignKey("UserID")]
        public User? User { get; set; }

        [ForeignKey("UserID")]
        // Navigation property for Anime (if you have an Anime model)
        public Anime? Anime { get; set; }
    }
}
