using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Client.ViewModels.Factories
{
    class PortfolioViewModelFactory : ISimpleTraderViewModeGenericlFactory<PortfolioViewModel>
    {
        public PortfolioViewModel CreateViewModel()
        {
            return new PortfolioViewModel();
        }
    }
}
