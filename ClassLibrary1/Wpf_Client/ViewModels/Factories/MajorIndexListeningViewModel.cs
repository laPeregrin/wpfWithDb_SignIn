using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Client.ViewModels.Factories
{
    class MajorIndexListeningViewModelFactory : ISimpleTraderViewModeGenericlFactory<MajorIndexListingViewModel>
    {
        private readonly IMajorIndexService _majorIndexService;

        public MajorIndexListeningViewModelFactory(IMajorIndexService majorIndexService)
        {
            _majorIndexService = majorIndexService;
        }

        public MajorIndexListingViewModel CreateViewModel()
        {
            return MajorIndexListingViewModel.LoadMajorIndexViewModel(_majorIndexService);
        }
    }
}
