using nc_recordshop_backend.Model;

namespace nc_recordshop_backend.Repository
{
    public interface IAlbumRepository
    {
        public List<Album> FetchAlbums();
        public Album? FetchAlbumById(int id);
        public Task<Album> PostAlbum(Album album);
        public Album PutAlbum(Album album, int id);
        public void DeleteAlbum(int id);
        public List<Album> FetchAlbumsByArtist(string name);
        public List<Album> FetchAlbumsByReleaseYear(int year);
        public List<Album> FetchAlbumsByGenre(string genre);
        public Album FetchAlbumInfoByName(string name);
    }

    public class AlbumRepository : IAlbumRepository
    {
        // constructor with a private db field here
        private MyDbContext _db;

        public AlbumRepository(MyDbContext db)
        {
            _db = db;
        }

        public List<Album> FetchAlbums()
        {
            return _db.Albums.ToList();
        }

        public Album? FetchAlbumById(int id)
        {
            return _db.Albums.FirstOrDefault(a => a.Id == id);
        }

        public async Task<Album> PostAlbum(Album album)
        {
            //album.Id = _db.Albums.Max(a => a.Id) + 1;
            _db.Albums.Add(album);
            // Test if this needs async
            await _db.SaveChangesAsync();


            return album;
        }

        public Album PutAlbum(Album album, int id)
        {
            var a = FetchAlbumById(id);
            // Could i just do a = album, and keep old id?
            if (a == null) { a = new Album(); }

            a.Quantity = album.Quantity;
            a.Name = album.Name;
            a.Description = album.Description;
            a.Artist = album.Artist;
            a.Genre = album.Genre;
            a.ReleaseDate = album.ReleaseDate;
            a.TrackList = album.TrackList;
            // async?
            _db.SaveChanges();


            return a;
        }

        public void DeleteAlbum(int id)
        {
            var album = _db.Albums.FirstOrDefault(a => a.Id == id);
            if (album != null)
            {
                _db.Albums.Remove(album);
            }
            // async?
            _db.SaveChanges();
        }

        // ---------- TODO -----------------------
        public List<Album> FetchAlbumsByArtist(string name)
        {
            return _db.Albums.Where(a => a.Artist == name).ToList();
        }

        public List<Album> FetchAlbumsByReleaseYear(int year)
        {
            return _db.Albums.Where(a => a.ReleaseDate.Year == year).ToList();
        }

        public List<Album> FetchAlbumsByGenre(string genre)
        {
            return _db.Albums.Where(a => a.Genre == genre).ToList();
        }

        public Album FetchAlbumInfoByName(string name)
        {
            return _db.Albums.FirstOrDefault(a => a.Name == name);
        }
    }
}
