using SQLite;

namespace PPP.Database
{
    public interface ISqliteProductCatalog
    {
        SQLiteConnection GetConnection();
    }
}
