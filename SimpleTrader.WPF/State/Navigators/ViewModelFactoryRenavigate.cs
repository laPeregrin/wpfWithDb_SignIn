using SimpleTrader.WPF.ViewModels;
using SimpleTrader.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.WPF.State.Navigators
{
    public class ViewModelFactoryRenavigate<TViewModel> : IRenavigator where TViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly ISimpleTraderViewModelFactory<TViewModel> _viewModelFactory;

        public ViewModelFactoryRenavigate(INavigator navigator, ISimpleTraderViewModelFactory<TViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
            _navigator = navigator;
        }

        public void Renvigate()
        {
            _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel();
        }
    }
}
