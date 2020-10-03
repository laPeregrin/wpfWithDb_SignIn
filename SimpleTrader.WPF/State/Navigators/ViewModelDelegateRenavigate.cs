using SimpleTrader.WPF.ViewModels;
using SimpleTrader.WPF.ViewModels.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.WPF.State.Navigators
{
    public class ViewModelDelegateRenavigate<TViewModel> : IRenavigator where TViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly CreateViewModel<TViewModel> _crateViewModel;

        public ViewModelDelegateRenavigate(INavigator navigator, CreateViewModel<TViewModel> crateViewModel)
        {
            _navigator = navigator;
            _crateViewModel = crateViewModel;
        }

        public void Renvigate()
        {
            _navigator.CurrentViewModel = _crateViewModel();
        }
    }
}
