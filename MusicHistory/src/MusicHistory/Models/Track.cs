using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHistory.Models
{
    public class Track
    {
        [Key]
        public int TrackId { get; set; }
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

        public AppUser AppUser { get; set; }
        
    }
}