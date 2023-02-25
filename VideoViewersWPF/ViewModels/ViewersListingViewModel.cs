using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoViewersWPF.ViewModels
{
    internal class ViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ViewersListingItemViewModel> _viewersListingItemViewModels;
        public IEnumerable<ViewersListingItemViewModel> ViewersListingItemViewModels => _viewersListingItemViewModels;

        public ViewersListingViewModel()
        {
            _viewersListingItemViewModels = new ObservableCollection<ViewersListingItemViewModel>();

            _viewersListingItemViewModels.Add(new ViewersListingItemViewModel("John"));
            _viewersListingItemViewModels.Add(new ViewersListingItemViewModel("Jef"));
            _viewersListingItemViewModels.Add(new ViewersListingItemViewModel("Mary"));
        }
    }
}
