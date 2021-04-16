using CoreMusic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMusic.Data
{
    public class MContext : DbContext
    {
        public MContext(DbContextOptions<MContext> options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().ToTable("Albums");
            modelBuilder.Entity<Artist>().ToTable("Artists");
            modelBuilder.Entity<Song>().ToTable("Songs");
        }
    }
}
