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

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
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
                switch(viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel(MajorIndexListingViewModel.LoadMajorIndexViewModel(new MajorIndexService()));
                        break;
                    case ViewType.Portfolio:
                        _navigator.CurrentViewModel = new PortfolioViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
        private bool alwaysTrue { get { return true; }}
    }
}
