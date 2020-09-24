using FinancialModelin;
using FinancialModelin.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Wpf_Client.States.Navigation;

namespace Wpf_Client.ViewModels.Factories
{
    class AbstractSimpleTraderViewModelFactory : ISimpleTraderViewModelAbstractFactory
    {
        private readonly ISimpleTraderViewModeGenericlFactory<HomeViewModel> _homeViewModelFactory;
        private readonly ISimpleTraderViewModeGenericlFactory<PortfolioViewModel> _portfolioViewModelFactory;
        private readonly ISimpleTraderViewModeGenericlFactory<BuyViewModel> _buyViewModelFactory;

        public AbstractSimpleTraderViewModelFactory(
            ISimpleTraderViewModeGenericlFactory<HomeViewModel> homeViewModelFactory, 
            ISimpleTraderViewModeGenericlFactory<PortfolioViewModel> portfolioViewModelFactory,
            ISimpleTraderViewModeGenericlFactory<BuyViewModel> buyViewModelFactory)
        {
            _homeViewModelFactory = homeViewModelFactory;
            _portfolioViewModelFactory = portfolioViewModelFactory;
            _buyViewModelFactory = buyViewModelFactory;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Home:
                    return _homeViewModelFactory.CreateViewModel();
                case ViewType.Portfolio:
                    return _portfolioViewModelFactory.CreateViewModel();
                case ViewType.Buy:
                    return _buyViewModelFactory.CreateViewModel();
                default:
                    return _portfolioViewModelFactory.CreateViewModel();
            }
        }
    }
}
