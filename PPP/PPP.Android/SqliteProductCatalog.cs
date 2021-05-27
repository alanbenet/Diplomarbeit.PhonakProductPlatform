using PPP.Database;
using PPP.Droid;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteProductCatalog))]

namespace PPP.Droid
{
    class SqliteProductCatalog : ISqliteProductCatalog
    {
        private const string ProductCatalogDb = "ProductCatalog.sqlite";
        public SQLiteConnection GetConnection()
        {
            string documentsPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = Path.Combine(documentsPath, ProductCatalogDb);

            if (!File.Exists(path))
            {
                
                Stream s = Forms.Context.Resources.OpenRawResource(Resource.Raw.ProductCatalog);

                FileStream writeStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                ReadWriteStream(s, writeStream);
            }

            var conn = new SQLiteConnection(path);
            return conn;
        }

        private void ReadWriteStream(Stream readStream, Stream writeStream)
        {
            int Length = 256;
            Byte[] buffer = new Byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = readStream.Read(buffer, 0, Length);
            }
            readStream.Close();
            writeStream.Close();
        }
    }
}
