using nc_recordshop_backend.Model;
using nc_recordshop_backend.Repository;

namespace nc_recordshop_backend.Service
{
    public interface IAlbumService
    {
        public List<Album> GetAlbums();
        public Album GetAlbumById(int id);
    }

    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public List<Album> GetAlbums()
        {
            return _albumRepository.FetchAlbums();
        }

        public Album GetAlbumById(int id)
        {
            return _albumRepository.FetchAlbumById(id);
        }
    }
}
