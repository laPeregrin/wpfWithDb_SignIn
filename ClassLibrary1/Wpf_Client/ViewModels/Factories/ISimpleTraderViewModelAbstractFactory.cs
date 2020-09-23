using System;
using System.Collections.Generic;
using System.Text;
using Wpf_Client.States.Navigation;

namespace Wpf_Client.ViewModels
{
    public interface ISimpleTraderViewModelAbstractFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
