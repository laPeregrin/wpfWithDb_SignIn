using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Client.ViewModels.Factories
{
    public class HomerViewModelFactory : ISimpleTraderViewModeGenericlFactory<HomeViewModel>
    {
        private ISimpleTraderViewModeGenericlFactory<MajorIndexListingViewModel> _majorIndexService;

        public HomerViewModelFactory(ISimpleTraderViewModeGenericlFactory<MajorIndexListingViewModel> majorIndexService)
        {
            _majorIndexService = majorIndexService;
        }

        public HomeViewModel CreateViewModel()
        {
            return new HomeViewModel(_majorIndexService.CreateViewModel());
        }
    }
}
