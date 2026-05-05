using Microsoft.AspNetCore.Mvc;
using nc_recordshop_backend.Model;

namespace nc_recordshop_backend.Controller
{
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAlbums()
        {
            return Ok(new Album());
        }
    }
}
