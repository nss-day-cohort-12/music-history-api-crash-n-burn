﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHistory.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }

        ICollection<Album> Albums { get; set; }
    }
}
