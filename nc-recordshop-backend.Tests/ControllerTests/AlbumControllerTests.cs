using nc_recordshop_backend.Controller;
using nc_recordshop_backend.Service;
using nc_recordshop_backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace nc_recordshop_backend.Tests.ControllerTests
{
    internal class AlbumControllerTests
    {
        private AlbumController _albumController;
        private Mock<IAlbumService> _albumServiceMock;

        [SetUp]
        public void Setup()
        {
            _albumServiceMock = new Mock<IAlbumService>();
            _albumController = new AlbumController(_albumServiceMock.Object);
        }

        /*[Test]
        public void GetAlbums_ReturnsListEmpty()
        {
            List<Album> albums = new();

            _albumServiceMock.Setup(a => a.GetAlbums()).Returns(albums);

            var actual = _albumController.GetAlbums();
            var a = actual as OkObjectResult;

            Assert.That(actual, Is.TypeOf<OkObjectResult>());
            Assert.That(a.Value, Is.EquivalentTo(albums));
        }*/

        /*[Test]
        public void GetAlbums_ReturnsListSingleAlbum()
        {
            DateOnly date = new DateOnly(1969, 9, 26);
            List<string> tracks = new() { "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus's Garden" };
            Album album1 = new("Abbey Road", "The last album the Beatles ever recorded", "The Beatles", "Rock", date, tracks);

            List<Album> albums = new();
            albums.Add(album1);


            _albumServiceMock.Setup(a => a.GetAlbums()).Returns(albums);

            var actual = _albumController.GetAlbums();
            var a = actual as OkObjectResult;

            Assert.That(actual, Is.TypeOf<OkObjectResult>());
            Assert.That(a.Value, Is.EquivalentTo(albums));
        }*/

        [Test]
        public void GetAlbums_ReturnsOKList_TwoAlbums()
        {
            DateOnly date1 = new DateOnly(1969, 9, 26);
            List<string> tracks1 = new() { "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus's Garden" };
            Album album1 = new();
            album1.Quantity = 67;
            album1.Name = "Abbey Road";
            album1.Description = "The last album the Beatles ever recorded";
            album1.Artist = "The Beatles";
            album1.Genre = "Rock";
            album1.ReleaseDate = date1;
            album1.TrackList = tracks1;



            DateOnly date2 = new DateOnly(1971, 11, 8);
            List<string> tracks2 = new() { "Black Dog", "Rock And Roll", "The Battle Of Evermore", "Stairway To Heaven", "Misty Mountain Hop", "Four Sticks", "Going To California", "When The Levee Breaks" };

            Album album2 = new();
            album2.Quantity = 23;
            album2.Name = "Led Zeppelin IV";
            album2.Description = "Recorded in Headley Grange in Hampshire";
            album2.Artist = "Led Zeppelin";
            album2.Genre = "Rock";
            album2.ReleaseDate = date2;
            album2.TrackList = tracks2;



            List<Album> albums = new();
            albums.Add(album1);
            albums.Add(album2);


            _albumServiceMock.Setup(a => a.GetAlbums()).Returns(albums);

            var actual = _albumController.GetAlbums();
            var a = actual as OkObjectResult;

            Assert.That(actual, Is.TypeOf<OkObjectResult>());
            Assert.That(a.Value, Is.EquivalentTo(albums));
        }

        [Test]
        public void GetAlbumById_PosId_ReturnsOKAlbum()
        {
            DateOnly date1 = new DateOnly(1969, 9, 26);
            List<string> tracks1 = new() { "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus's Garden" };
            Album album1 = new();
            album1.Id = 1;
            album1.Quantity = 67;
            album1.Name = "Abbey Road";
            album1.Description = "The last album the Beatles ever recorded";
            album1.Artist = "The Beatles";
            album1.Genre = "Rock";
            album1.ReleaseDate = date1;
            album1.TrackList = tracks1;

            int id = 1;


            _albumServiceMock.Setup(a => a.GetAlbumById(id)).Returns(album1);

            var actual = _albumController.GetAlbumById(id);

            Assert.That(actual, Is.TypeOf<OkObjectResult>());

            var a = actual as OkObjectResult;

            Assert.That(a.Value, Is.EqualTo(album1));
        }

        [Test]
        public void GetAlbumById_NegId_ReturnsBadReq()
        {
            // maybe change this to match seeding
            DateOnly date1 = new DateOnly(1969, 9, 26);
            List<string> tracks1 = new() { "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus's Garden" };
            Album album1 = new();
            album1.Id = 1;
            album1.Quantity = 67;
            album1.Name = "Abbey Road";
            album1.Description = "The last album the Beatles ever recorded";
            album1.Artist = "The Beatles";
            album1.Genre = "Rock";
            album1.ReleaseDate = date1;
            album1.TrackList = tracks1;

            int id = -5;

            _albumServiceMock.Setup(a => a.GetAlbumById(id)).Returns((Album?)null);

            var actual = _albumController.GetAlbumById(id);

            Assert.That(actual, Is.TypeOf<BadRequestResult>());
        }

        [Test]
        public void GetAlbumById_PosId_ReturnsNotFound()
        {
            int id = 5;

            var actual = _albumController.GetAlbumById(id);

            Assert.That(actual, Is.TypeOf<NotFoundResult>());
        }

        [Test]
        public async Task AddAlbum_ReturnsOk()
        {
            DateOnly date1 = new DateOnly(1969, 9, 26);
            List<string> tracks1 = new() { "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus's Garden" };
            Album album1 = new();
            album1.Id = 1;
            album1.Quantity = 67;
            album1.Name = "Abbey Road";
            album1.Description = "The last album the Beatles ever recorded";
            album1.Artist = "The Beatles";
            album1.Genre = "Rock";
            album1.ReleaseDate = date1;
            album1.TrackList = tracks1;


            _albumServiceMock.Setup(a => a.AddAlbum(album1)).ReturnsAsync(album1);

            var actual = (OkObjectResult)(await _albumController.AddAlbum(album1));


            Assert.That(actual, Is.TypeOf<OkObjectResult>());

            Assert.That(actual.Value, Is.EqualTo(album1));
        }

        [Test]
        public void UpdateAlbum_PosId_ReturnsOKAlbum()
        {
            DateOnly date1 = new DateOnly(2006, 8, 27);
            List<string> tracks1 = new() { "Rehab", "You Know I'm No Good", "Me And Mr Jones", "Just Friends", "Back To Black", "Love Is A Losing Game", "Tears Dry On Their Own", "Wake Up Alone", "Some Unholy War", "He Can Only Hold Her", "Addicted" };
            Album album1 = new();
            album1.Id = 0;
            album1.Quantity = 67;
            album1.Name = "Back to Black";
            album1.Description = "Old school soul music";
            album1.Artist = "Amy Winehouse";
            album1.Genre = "Funk/Soul";
            album1.ReleaseDate = date1;
            album1.TrackList = tracks1;

            int id = 2;


            _albumServiceMock.Setup(a => a.UpdateAlbum(album1, id)).Returns(album1);

            var actual = _albumController.UpdateAlbum(album1, id);

            Assert.That(actual, Is.TypeOf<OkObjectResult>());

            var a = actual as OkObjectResult;

            Assert.That(a.Value, Is.EqualTo(album1));
        }

        [Test]
        public void UpdateAlbum_NegId_ReturnsBadReq()
        {
            // maybe change this to match seeding
            DateOnly date1 = new DateOnly(2006, 8, 27);
            List<string> tracks1 = new() { "Rehab", "You Know I'm No Good", "Me And Mr Jones", "Just Friends", "Back To Black", "Love Is A Losing Game", "Tears Dry On Their Own", "Wake Up Alone", "Some Unholy War", "He Can Only Hold Her", "Addicted" };
            Album album1 = new();
            album1.Id = 0;
            album1.Quantity = 67;
            album1.Name = "Back to Black";
            album1.Description = "Old school soul music";
            album1.Artist = "Amy Winehouse";
            album1.Genre = "Funk/Soul";
            album1.ReleaseDate = date1;
            album1.TrackList = tracks1;

            int id = -5;

            _albumServiceMock.Setup(a => a.UpdateAlbum(album1, id)).Returns((Album?)null);

            var actual = _albumController.UpdateAlbum(album1, id);

            Assert.That(actual, Is.TypeOf<BadRequestResult>());
        }

        [Test]
        public void UpdateAlbum_PosId_ReturnsNotFound()
        {
            DateOnly date1 = new DateOnly(2006, 8, 27);
            List<string> tracks1 = new() { "Rehab", "You Know I'm No Good", "Me And Mr Jones", "Just Friends", "Back To Black", "Love Is A Losing Game", "Tears Dry On Their Own", "Wake Up Alone", "Some Unholy War", "He Can Only Hold Her", "Addicted" };
            Album album1 = new();
            album1.Id = 0;
            album1.Quantity = 67;
            album1.Name = "Back to Black";
            album1.Description = "Old school soul music";
            album1.Artist = "Amy Winehouse";
            album1.Genre = "Funk/Soul";
            album1.ReleaseDate = date1;
            album1.TrackList = tracks1;

            int id = 5;

            var actual = _albumController.UpdateAlbum(album1, id);

            Assert.That(actual, Is.TypeOf<NotFoundResult>());
        }

        //---------------------------------------------------

        [Test]
        public void RemoveAlbum_PosId_ReturnsOK()
        {

            int id = 2;


            //_albumServiceMock.Setup(a => a.RemoveAlbum(id));

            var actual = _albumController.RemoveAlbum(id);

            Assert.That(actual, Is.TypeOf<OkResult>());
            _albumServiceMock.Verify(a => a.RemoveAlbum(id), Times.Once());
        }

        [Test]
        public void RemoveAlbum_NegId_ReturnsBadReq()
        {
            int id = -5;

            var actual = _albumController.RemoveAlbum(id);

            Assert.That(actual, Is.TypeOf<BadRequestResult>());
            _albumServiceMock.Verify(a => a.RemoveAlbum(id), Times.Once());
        }

        /*// Save this for exception handling
        [Test]
        public void RemoveAlbum_PosId_ReturnsNotFound()
        {
            int id = 5;

            var actual = _albumController.RemoveAlbum(id);

            Assert.That(actual, Is.TypeOf<NotFoundResult>());
            _albumServiceMock.Verify(a => a.RemoveAlbum(id), Times.Once());
        }*/
    }

        /*[Test]
        public void AddAlbum_ReturnsBadRequest()
        {

        }*/
}