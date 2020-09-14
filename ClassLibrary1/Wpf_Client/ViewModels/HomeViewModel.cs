using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Client.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        public MajorIndexViewModel _MajorIndexViewModel { get; set; }

        public HomeViewModel(MajorIndexViewModel majorIndexViewModel)
        {
            _MajorIndexViewModel = majorIndexViewModel;
        }
    }
}
