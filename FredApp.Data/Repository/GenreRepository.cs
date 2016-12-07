using FredApp.Common;
using FredApp.Common.Models;
using FredApp.Data.DataAccess;
using System.Collections.Generic;


namespace FredApp.Data.Repository
{
    public class GenreRepository : BaseConnection<GenreRepository>
    {
        public Genre GetGenre(int genreId)
        {
            return SimpleCRUD.Get<Genre>(Connection, genreId);
        }

        public IEnumerable<Genre> GetList()
        {
            return SimpleCRUD.GetList<Genre>(Connection);
        }

        public OperationStatus Update(Genre genre)
        {

            var opStatus = new OperationStatus { Status = true };

            try
            {
                SimpleCRUD.Update(Connection, genre);
            }
            catch (System.Exception ex)
            {

                opStatus.Status = false;
                opStatus.ExceptionInnerMessage = ex.Message;
            }

            return opStatus;
        }


        public OperationStatus Insert(Genre genre)
        {

            var opStatus = new OperationStatus { Status = true };

            try
            {
                SimpleCRUD.Insert<Genre>(Connection, genre);
            }
            catch (System.Exception ex)
            {

                opStatus.Status = false;
                opStatus.ExceptionInnerMessage = ex.Message;
            }

            return opStatus;
        }


    }
}
