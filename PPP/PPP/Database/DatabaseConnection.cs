using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace PPP.Database
{
    class DatabaseConnection : IDatabaseConnection
    {
        private SQLiteConnection dbConn;

        public SQLiteConnection CheckConnectionProductCatalogDb()
        {
            return dbConn = DependencyService.Get<ISqliteProductCatalog>().GetConnection();
        }

    }
}
