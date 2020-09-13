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

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch(viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModels = new HomeViewModel();
                            break;
                    case ViewType.Portfolio:
                        _navigator.CurrentViewModels = new PortfolioViewModel();
                            break;
                }
            }
            

        }
    }
}
