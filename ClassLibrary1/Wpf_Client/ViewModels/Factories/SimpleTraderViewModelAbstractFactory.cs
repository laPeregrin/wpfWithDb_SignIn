using FinancialModelin;
using FinancialModelin.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Wpf_Client.States.Navigation;

namespace Wpf_Client.ViewModels.Factories
{
    class SimpleTraderViewModelAbstractFactory : ISimpleTraderViewModelAbstractFactory
    {
        private readonly ISimpleTraderViewModeGenericlFactory<HomeViewModel> _homeViewModelFactory;
        private readonly ISimpleTraderViewModeGenericlFactory<PortfolioViewModel> _portfolioViewModelFactory;

        public SimpleTraderViewModelAbstractFactory(
            ISimpleTraderViewModeGenericlFactory<HomeViewModel> homeViewModelFactory, 
            ISimpleTraderViewModeGenericlFactory<PortfolioViewModel> portfolioViewModelFactory)
        {
            _homeViewModelFactory = homeViewModelFactory;
            _portfolioViewModelFactory = portfolioViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return _homeViewModelFactory.CreateViewModel();
                case ViewType.Portfolio:
                default:
                    return _portfolioViewModelFactory.CreateViewModel();
            }
        }
    }
}
