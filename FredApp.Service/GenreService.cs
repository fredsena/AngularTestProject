using FredApp.Common.Models;
using FredApp.Data.Repository;
using System.Collections.Generic;

namespace FredApp.Service
{
    public class GenreService
    {
        public IEnumerable<Genre> GetList()
        {
            return new GenreRepository().GetList();
        }
    }
}
