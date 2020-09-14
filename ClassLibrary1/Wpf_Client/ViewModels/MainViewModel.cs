using System;
using System.Collections.Generic;
using System.Text;
using Wpf_Client.States.Navigation;

namespace Wpf_Client.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private INavigator navigator = new Navigator();
        public INavigator Navigator { get { return navigator; } set { navigator = value; OnPropertyChanged(); } }
    }
}
