using Domain.Models;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Client.ViewModels
{
    class MajorIndexViewModel : ViewModelBase
    {
        public IMajorIndexService _indexService;
        public MajorIndex DowJones { get; set; }
        public MajorIndex Nasdaq { get; set; }
        public MajorIndex SP500 { get; set; }
        public MajorIndexViewModel(IMajorIndexService indexService)
        {
            _indexService = indexService;
        }
        public static MajorIndexViewModel LoadMajorIndexViewModel(IMajorIndexService majorIndexService)
        {
            MajorIndexViewModel majorIndexViewModel = new MajorIndexViewModel(majorIndexService);
            majorIndexViewModel.LoadMajorIndexes();
            return majorIndexViewModel;
        }
        private void LoadMajorIndexes()
        {
            _indexService.GetMajorIndex(MajorIndexType.DownJones).ContinueWith(task =>
            {
                if(task.Exception == null)
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
