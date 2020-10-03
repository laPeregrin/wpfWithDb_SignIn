using SimpleTrader.WPF.Commands;
using SimpleTrader.WPF.State.Authenticators;
using SimpleTrader.WPF.State.Navigators;
using SimpleTrader.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SimpleTrader.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ISimpleTraderViewModelFactory viewModelFactory;

        public INavigator Navigator { get; set; }
        public IAuthenticator Authenticator { get; }
        public ICommand UpdateCurrentViewModelCommand { get; }

        public MainViewModel(INavigator navigator,ISimpleTraderViewModelFactory _viewModelFactory ,IAuthenticator authenticator)
        {
            Navigator = navigator;
            viewModelFactory = _viewModelFactory;
            Authenticator = authenticator;
            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(navigator, _viewModelFactory);
            UpdateCurrentViewModelCommand.Execute(ViewType.Login);
        }
    }
}
