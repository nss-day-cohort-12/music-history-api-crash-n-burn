using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHistory.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }

        ICollection<Track> Tracks { get; set; }
    }
}
