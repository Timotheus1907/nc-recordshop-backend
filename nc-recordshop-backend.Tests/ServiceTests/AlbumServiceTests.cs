using Microsoft.AspNetCore.Mvc;
using Moq;
using nc_recordshop_backend.Controller;
using nc_recordshop_backend.Model;
using nc_recordshop_backend.Repository;
using nc_recordshop_backend.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nc_recordshop_backend.Tests.ServiceTests
{
    internal class AlbumServiceTests
    {
        private AlbumService _albumService;
        private Mock<IAlbumRepository> _albumRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _albumRepositoryMock = new Mock<IAlbumRepository>();
            _albumService = new AlbumService(_albumRepositoryMock.Object);
        }

        [Test]
        public void GetAlbums_ReturnsListSingleAlbum()
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

            List<Album> albums = new();
            albums.Add(album1);


            _albumRepositoryMock.Setup(a => a.FetchAlbums()).Returns(albums);

            var actual = _albumService.GetAlbums();

            Assert.That(actual, Is.EquivalentTo(albums));
        }
    }
}
