using FinancialModelin;
using FinancialModelin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_Client.States.Navigation;
using Wpf_Client.ViewModels;

namespace Wpf_Client.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly INavigator _navigator;
        private readonly ISimpleTraderViewModelAbstractFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(
            INavigator navigator, 
            ISimpleTraderViewModelAbstractFactory viewModelFactory)
        {
            _navigator = navigator;
            _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object parameter)
        {
            return alwaysTrue;
        }
        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                _navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
            }
        }
        private bool alwaysTrue { get { return true; }}
    }
}
