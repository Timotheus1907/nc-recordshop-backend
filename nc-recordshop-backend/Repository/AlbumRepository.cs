using nc_recordshop_backend.Model;

namespace nc_recordshop_backend.Repository
{
    public interface IAlbumRepository
    {
        public List<Album> FetchAlbums();
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
            Console.WriteLine("mnkgnh");
            foreach (var a in _db.Albums)
            {
                Console.WriteLine("XXXA");
                Console.WriteLine(a.Name);
            }

            return _db.Albums.ToList();
        }
    }
}
