using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AP01Project.Core;
using AP01Project.MVVM.ViewModel;

namespace AP01Project.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVm { get; set; }
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CurrentView = HomeVm;

        }
    }
}
