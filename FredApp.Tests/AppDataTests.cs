using FredApp.Common.Models;
using FredApp.Data.Repository;
using Xunit;

namespace FredApp.Tests
{

    public class AppDataTests
    {

        [Fact]
        public void ConnectionSucceded()
        {
            var genre = new Genre();
            var repo = new GenreRepository();
            var conn = repo.Connection;            
            Assert.NotNull(conn);
        }

        [Fact]
        public void GetGenre()
        {
            var genre = new Genre();
            var repo = new GenreRepository();
            genre = repo.GetGenre(2);            
            Assert.NotNull(genre);
        }

        [Fact]
        public void GetGenreList()
        {
            var repo = new GenreRepository();
            var list = repo.GetList();

            Assert.NotNull(list);
        }

    }
}
