using FredApp.Common.Models;
using FredApp.Data.DataAccess;
using System.Collections.Generic;


namespace FredApp.Data.Repository
{
    public class GenreRepository: BaseConnection<GenreRepository>
    {
        public Genre GetGenre(int genreId)
        {
            return SimpleCRUD.Get<Genre>(Connection, genreId);            
        }

        public IEnumerable<Genre> GetList()
        {
            return SimpleCRUD.GetList<Genre>(Connection);
        }



    }
}
