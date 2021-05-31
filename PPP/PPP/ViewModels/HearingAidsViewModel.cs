using PPP.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace PPP.ViewModels
{
    public class HearingAidsViewModel
    {
        private ObservableCollection<IGrouping<string, Hi>> _groupedCollection;
        private IHearingAidsRepo _hearingAidsRepo;
        

        public HearingAidsViewModel(IHearingAidsRepo hearingAidsRepo)
        {
            _hearingAidsRepo = hearingAidsRepo;
            GroupedHearingAids = new ObservableCollection<IGrouping<string, Hi>>();
            GroupHearingAidsByFamilyName();
        }

        public ObservableCollection<IGrouping<string, Hi>> GroupedHearingAids
        {
            get => _groupedCollection;
            set => _groupedCollection = value;
        }

        private void GroupHearingAidsByFamilyName()
        {
            var groupedList = _hearingAidsRepo.GetAllHis().GroupBy(x => x.DisplayName);
            foreach (var item in groupedList)
            {
                GroupedHearingAids.Add(item);
            }
        }
    }
}
