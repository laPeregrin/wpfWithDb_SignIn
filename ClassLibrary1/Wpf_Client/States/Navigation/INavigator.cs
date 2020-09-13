using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_Client.ViewModels;

namespace Wpf_Client.States.Navigation
{
    public enum ViewType
    {
        Home,
        Portfolio
    }
    public interface INavigator
    {
        ViewModelBase CurrentViewModels { get; set; }
        ICommand UpdateCurrentViewModel { get; }
    }
}
