﻿using System;
using System.Collections.Generic;
using System.Text;
using Wpf_Client.States.Navigation;

namespace Wpf_Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; }

        public MainViewModel(INavigator navigator)
        {
            Navigator = navigator;
            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Home);
        }
    }
}
