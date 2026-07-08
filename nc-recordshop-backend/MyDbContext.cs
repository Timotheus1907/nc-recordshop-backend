using Microsoft.EntityFrameworkCore;

using nc_recordshop_backend.Model;
using System.Text.Json;

namespace nc_recordshop_backend
{
    public class MyDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var albums = JsonSerializer.Deserialize<List<Album>>(File.ReadAllText("Resources/AlbumData.json"));
            modelBuilder.Entity<Album>().HasData(albums);
        }
    }
}
