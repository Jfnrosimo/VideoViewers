using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VideoViewersWPF.ViewModels
{
    internal class ViewersViewModel : ViewModelBase
    {
        public ViewersListingViewModel ViewersListingViewModel { get; }
        public ViewersDetailsViewModel ViewersDetailsViewModel { get; }

        public ICommand AddViewersCommand { get; }

        public ViewersViewModel()
        {
            ViewersListingViewModel = new ViewersListingViewModel();
            ViewersDetailsViewModel = new ViewersDetailsViewModel();
        }
    }
}
