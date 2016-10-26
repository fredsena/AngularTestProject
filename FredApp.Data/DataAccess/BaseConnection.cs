using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FredApp.Data.Interfaces;

namespace FredApp.Data.DataAccess
{
    public class BaseConnection<T> : IBaseConnection<T>
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["dbfredsenaContext"].ConnectionString);
            }
        }
    }
}
