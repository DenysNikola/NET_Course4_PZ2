using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2
{
    public class Anime
    {
        [Key]
        public int AnimeID { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string? Description { get; set; }
        public decimal Rating { get; set; }
        public int TotalEpisodes { get; set; }

        public ICollection<UserAnimeList>? UserAnimeList { get; set; }
    }
}
