using nc_recordshop_backend.Model;

namespace nc_recordshop_backend.Repository
{
    public interface IAlbumRepository
    {
        public List<Album> FetchAlbums();
        public Album? FetchAlbumById(int id);
        public Album PostAlbum(Album album);
        public Album PutAlbum(Album album, int id);
        public void DeleteAlbum(int id);
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

        public Album PostAlbum(Album album)
        {
            album.Id = _db.Albums.Max(a => a.Id) + 1;
            _db.Albums.Add(album);
            // Test if this needs async
            _db.SaveChanges();


            return album;
        }

        public Album PutAlbum(Album album, int id)
        {
            var a = FetchAlbumById(id);
            // Could i just do a = album, and keep old id?

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
    }
}
