using Microsoft.AspNetCore.Mvc;
using nc_recordshop_backend.Model;
using nc_recordshop_backend.Repository;

namespace nc_recordshop_backend.Service
{
    public interface IAlbumService
    {
        public List<Album> GetAlbums();
        public Album? GetAlbumById(int id);
        public Task<Album> AddAlbum(Album album);
        public Album UpdateAlbum(Album album, int id);
        public Task RemoveAlbum(int id);
        public List<Album> GetAlbumsByArtist(string name);
        public List<Album> GetAlbumsByReleaseYear(int year);
        public List<Album> GetAlbumsByGenre(string genre);
        public Album GetAlbumInfoByName(string name);
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

        public Album? GetAlbumById(int id)
        {
            return _albumRepository.FetchAlbumById(id);
        }

        public async Task<Album> AddAlbum(Album album)
        {
            return await _albumRepository.PostAlbum(album);
        }
        
        public Album UpdateAlbum(Album album,int id)
        {
            return _albumRepository.PutAlbum(album, id);
        }

        public async Task RemoveAlbum(int id)
        {
            await _albumRepository.DeleteAlbum(id);
        }

        public List<Album> GetAlbumsByArtist(string name)
        {
            return _albumRepository.FetchAlbumsByArtist(name);
        }

        public List<Album> GetAlbumsByReleaseYear(int year)
        {
            return _albumRepository.FetchAlbumsByReleaseYear(year);
        }

        public List<Album> GetAlbumsByGenre(string genre)
        {
            return _albumRepository.FetchAlbumsByGenre(genre);
        }

        public Album GetAlbumInfoByName(string name)
        {
            return _albumRepository.FetchAlbumInfoByName(name);
        }
    }
}
