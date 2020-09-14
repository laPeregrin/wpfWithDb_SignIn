using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Wpf_Client.Commands;
using Wpf_Client.ViewModels;

namespace Wpf_Client.States.Navigation
{
    public class Navigator : INavigator
    {
        ViewModelBase INavigator.CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
       
    }
}
