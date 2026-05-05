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
            Console.WriteLine("TEST");
            return Ok(_albumService.GetAlbums());
        }
    }
}
