﻿using FredApp.Common;
using FredApp.Common.Models;
using FredApp.Data.Repository;
using System.Collections.Generic;

namespace FredApp.Service
{
    public class GenreService
    {
        public IEnumerable<Genre> GetList()
        {
            var repo = new GenreRepository();

            return repo.GetList();
        }

        public OperationStatus Insert(Genre genre)
        {
            var repo = new GenreRepository();

            return repo.Insert(genre);
        }


        public OperationStatus Update(Genre genre)
        {
            var repo = new GenreRepository();

            return repo.Update(genre);
        }

    }
}
