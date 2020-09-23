using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Client.ViewModels.Factories
{
    public interface ISimpleTraderViewModeGenericlFactory<T> where T : ViewModelBase
    {
        T CreateViewModel();
    }
}
