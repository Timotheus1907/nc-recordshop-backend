using nc_recordshop_backend.Repository;

namespace nc_recordshop_backend.Service
{
    public interface IAlbumService
    {

    }

    public class AlbumService : IAlbumService
    {
        private readonly AlbumRepository _albumRepository;

        public AlbumService(AlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
    }
}
