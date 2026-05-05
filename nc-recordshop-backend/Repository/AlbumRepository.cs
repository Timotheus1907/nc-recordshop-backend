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


        public List<Album> FetchAlbums()
        {
            return new List<Album>();
        }
    }
}
