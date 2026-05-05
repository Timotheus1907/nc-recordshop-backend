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
            this.Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("AlbumTestingDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var albums = JsonSerializer.Deserialize<List<Album>>(File.ReadAllText("Resources\\AlbumData.json"));
            Console.WriteLine("TEST5");
            albums.ForEach(a => Console.WriteLine(a.Name));
            albums.ForEach(a => Console.WriteLine(a.Description));
            albums.ForEach(a => Console.WriteLine(a.Artist));
            albums.ForEach(a => Console.WriteLine(a.Genre));
            albums.ForEach(a => Console.WriteLine(a.Id));
            albums.ForEach(a => Console.WriteLine(a.ReleaseDate));
            albums.ForEach(a => a.TrackList.ForEach(b => Console.WriteLine(b)));
            Console.WriteLine("TEST6");
            modelBuilder.Entity<Album>().HasData(albums);
            
            //Console.WriteLine(Albums.Count());
        }
    }
}
