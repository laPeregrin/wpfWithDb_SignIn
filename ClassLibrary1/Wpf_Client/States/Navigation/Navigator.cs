using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Wpf_Client.Commands;
using Wpf_Client.ViewModels;

namespace Wpf_Client.States.Navigation
{
    public class Navigator : ViewModelBase, INavigator
    {
        private ViewModelBase _CurrentViewModel { get; set; }
        public ViewModelBase CurrentViewModel { get { return _CurrentViewModel; } set { _CurrentViewModel = value; OnPropertyChanged(); } }
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

        
    }
}
