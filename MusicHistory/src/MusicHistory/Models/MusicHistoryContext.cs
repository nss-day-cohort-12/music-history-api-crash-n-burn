using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicHistory.Models
{
    public class MusicHistoryContext : DbContext
    {
        public MusicHistoryContext(DbContextOptions<MusicHistoryContext> options)
            : base(options)
        { }

        //The name of the DbSet is what the migration uses to name the DB tables
        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
    }
}
