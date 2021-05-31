using SQLite;
using Xamarin.Forms;

namespace PPP.Database
{
    class DatabaseConnection : IDatabaseConnection
    {
        public SQLiteConnection CheckConnectionProductCatalogDb()
        {
            return DependencyService.Get<ISqliteProductCatalog>().GetConnection();
        }

    }
}
