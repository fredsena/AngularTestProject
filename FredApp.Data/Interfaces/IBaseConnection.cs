using System.Data;

namespace FredApp.Data.Interfaces
{
    public interface IBaseConnection<T>
    {
        IDbConnection Connection { get; }
    }
}
