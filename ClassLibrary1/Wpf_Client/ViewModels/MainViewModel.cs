using System;
using System.Collections.Generic;
using System.Text;
using Wpf_Client.States.Navigation;

namespace Wpf_Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private INavigator _Navigator { get; set; } = new Navigator();
        public INavigator Navigator { get { return _Navigator; } set { _Navigator = value; OnPropertyChanged(); } }

        public MainViewModel()
        {
            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Home);
        }
    }
}
