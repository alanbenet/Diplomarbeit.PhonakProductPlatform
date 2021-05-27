using PPP.Database;
using SQLite;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace PPP.Models
{
    class AccessoryRepo : IAccessoryRepo
    {

        private SQLiteConnection _dbConn;
        private IDatabaseConnection _databaseConnection;

        public AccessoryRepo(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Accessory> GetAllAccessoires()
        {
            _dbConn = _databaseConnection.CheckConnectionProductCatalogDb();
            List<Accessory> accessoiresList = _dbConn.Query<Accessory>(
                "Select Accessory.ProductionDisplayName, Accessory.AccessoryType, Accessory.SapPartNumber, Accessory.BlobType, Blobs.Content  from Accessory JOIN Blobs ON Accessory.BlobType = Blobs.BlobType");
            int i = 0;
            foreach (Accessory image in accessoiresList)
            {
                ImageSource imageContent = ImageSource.FromStream(() => new MemoryStream(image.Content));
                accessoiresList[i].Image = imageContent;
                i++;
            }
            return accessoiresList;
        }
    }
}
