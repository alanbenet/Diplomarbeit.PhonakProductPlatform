using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PPP.Database
{
    public interface IDatabaseConnection
    {
        SQLiteConnection CheckConnectionProductCatalogDb();
    }
}
