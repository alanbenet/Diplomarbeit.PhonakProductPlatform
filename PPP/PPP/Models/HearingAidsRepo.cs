using PPP.Database;
using SQLite;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace PPP.Models
{
    public class HearingAidsRepo : IHearingAidsRepo
    {
        private SQLiteConnection dbConn;
        private IDatabaseConnection _databaseConnection;

        public HearingAidsRepo(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        public List<Hi> GetAllHis()
        {
            dbConn = _databaseConnection.CheckConnectionProductCatalogDb();
            List<Hi> hearingAidsList = dbConn.Query<Hi>("Select Hi.Id, Hi.ProductionDisplayName, Hi.SapPartNumber, HiFamily.DisplayName, HiBlobTypeMapping.BlobType, Blobs.Content From Hi JOIN Family ON Hi.fkFamilyId = Family.Id JOIN HiFamily ON Family.Id = HiFamily.fkFamilyId INNER JOIN HiBlobTypeMapping ON HiBlobTypeMapping.fkHiId = Hi.Id JOIN Blobs ON HiBlobTypeMapping.BlobType = Blobs.BlobType GROUP BY Hi.Id");
            int i = 0;
            foreach (var image in hearingAidsList)
            {
                ImageSource imageContent = ImageSource.FromStream(() => new MemoryStream(image.Content));
                hearingAidsList[i].Image = imageContent;
                i++;
            }
            return hearingAidsList;
        }
    }
}
