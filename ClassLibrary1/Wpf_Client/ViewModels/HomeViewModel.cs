using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Client.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public MajorIndexListingViewModel _MajorIndexListingViewModel { get; set; }

        public HomeViewModel(MajorIndexListingViewModel majorIndexViewModel)
        {
            _MajorIndexListingViewModel = majorIndexViewModel;
        }
    }
}
