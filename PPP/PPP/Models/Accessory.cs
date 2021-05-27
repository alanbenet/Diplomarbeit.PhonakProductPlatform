using SQLite;
using Xamarin.Forms;

namespace PPP.Models
{
    public class Accessory
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }

        public string ProductionDisplayName { get; set; }
        public string  AccessoryType { get; set; }
        public string SapPartNumber { get; set; }
        public int BlobType { get; set; }
        public byte[] Content { get; set; }
        public ImageSource Image { get; set; }
    }
}
