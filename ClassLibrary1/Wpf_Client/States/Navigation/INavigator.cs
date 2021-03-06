﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_Client.ViewModels;

namespace Wpf_Client.States.Navigation
{
    public enum ViewType
    {
        Home,
        Portfolio,
        Buy
    }
    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
