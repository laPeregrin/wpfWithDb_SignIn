using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Client.ViewModels
{
    public class MajorIndexListingViewModel : ViewModelBase
    {
        public IMajorIndexService _indexService;
        private MajorIndex _DowJones;
        private MajorIndex _Nasdaq;
        private MajorIndex _SP500;
        public MajorIndex DowJones { get { return _DowJones; } set { _DowJones = value; OnPropertyChanged(); } }
        public MajorIndex Nasdaq { get { return _Nasdaq; } set { _Nasdaq = value; OnPropertyChanged(); } }
        public MajorIndex SP500 { get { return _SP500; } set { _SP500 = value; OnPropertyChanged(); } }
        public MajorIndexListingViewModel(IMajorIndexService indexService)
        {
            _indexService = indexService;
        }
        public static MajorIndexListingViewModel LoadMajorIndexViewModel(IMajorIndexService majorIndexService)
        {
            MajorIndexListingViewModel majorIndexViewModel = new MajorIndexListingViewModel(majorIndexService);
            majorIndexViewModel.LoadMajorIndexes();
            return majorIndexViewModel;
        }
        private void LoadMajorIndexes()
        {
            _indexService.GetMajorIndex(MajorIndexType.DownJones).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    DowJones = task.Result;
                }
            });
            _indexService.GetMajorIndex(MajorIndexType.Nasdaq).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    Nasdaq = task.Result;
                }
            });
            _indexService.GetMajorIndex(MajorIndexType.SP500).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    SP500 = task.Result;
                }
            });
        }
    }
}
