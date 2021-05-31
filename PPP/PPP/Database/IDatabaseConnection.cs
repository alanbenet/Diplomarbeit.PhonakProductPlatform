using SQLite;

namespace PPP.Database
{
    public interface IDatabaseConnection
    {
        SQLiteConnection CheckConnectionProductCatalogDb();
    }
}
