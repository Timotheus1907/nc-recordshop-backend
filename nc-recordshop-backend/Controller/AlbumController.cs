using Microsoft.AspNetCore.Mvc;
using nc_recordshop_backend.Model;
using nc_recordshop_backend.Service;

namespace nc_recordshop_backend.Controller
{
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public IActionResult GetAlbums()
        {
            return Ok(_albumService.GetAlbums());
        }

        [HttpGet("{id}")]
        public IActionResult GetAlbumById(int id)
        {
            var album = _albumService.GetAlbumById(id);

            if (id <= 0)
            {
                return BadRequest();
            }

            if (album == null)
            {
                return NotFound();
            }

            return Ok(_albumService.GetAlbumById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddAlbum([FromBody] Album album)
        {
            var albumReturned = await _albumService.AddAlbum(album);
            return Ok(albumReturned);
        }

        // In Swagger, the id parameter is the very first id value
        [HttpPut("{id}")]
        public IActionResult UpdateAlbum([FromBody] Album album, int id)
        {
            var returnAlbum = _albumService.UpdateAlbum(album, id);

            if (id <= 0)
            {
                return BadRequest();
            }

            if (returnAlbum == null)
            {
                return NotFound();
            }

            return Ok(returnAlbum);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveAlbum(int id)
        {
            // could be bool on success
            _albumService.RemoveAlbum(id);

            if (id <= 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("artist/{name}")]
        public IActionResult GetAlbumsByArtist(string name)
        {
            return Ok(_albumService.GetAlbumsByArtist(name));
        }

        [HttpGet("year/{year}")]
        public IActionResult GetAlbumsByReleaseYear(int year)
        {
            return Ok(_albumService.GetAlbumsByReleaseYear(year));
        }

        [HttpGet("genre/{genre}")]
        public IActionResult GetAlbumsByGenre(string genre)
        {
            return Ok(_albumService.GetAlbumsByGenre(genre));
        }

        [HttpGet("album/{name}")]
        public IActionResult GetAlbumInfoByName(string name)
        {
            return Ok(_albumService.GetAlbumInfoByName(name));
        }
    }
}
