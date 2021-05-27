using PPP.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace PPP.ViewModels
{
    public class AccessoiresViewModel
    {
        private IAccessoryRepo _accessoryRepo;
        private ObservableCollection<Accessory> _accessoryList;
        private ObservableCollection<IGrouping<string, Accessory>> _groupedCollection;

        public AccessoiresViewModel(IAccessoryRepo accessoryRepo)
        {
            _accessoryRepo = accessoryRepo;
            GroupedAccessoires = new ObservableCollection<IGrouping<string, Accessory>>();
            GroupAccessoiresByType();
        }

        public ObservableCollection<IGrouping<string, Accessory>> GroupedAccessoires { get; set; }


        private void GroupAccessoiresByType()
        {
            var groupedList = _accessoryRepo.GetAllAccessoires().GroupBy(x => x.AccessoryType);
            foreach (var item in groupedList)
            {
                GroupedAccessoires.Add(item);
            }
        }
    }
}
