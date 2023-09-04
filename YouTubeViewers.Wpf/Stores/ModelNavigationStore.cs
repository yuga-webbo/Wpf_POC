using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Wpf.ViewModels;

namespace YouTubeViewers.Wpf.Stores
{
    public class ModelNavigationStore
    {
		private ViewModelBase _currentViewModel;
		public ViewModelBase CurrentViewModel
        {
			get
			{
				return _currentViewModel;
			}
			set
			{
				_currentViewModel = value;
				CurrentViewModelChanged?.Invoke();

            }
		}
		public event Action CurrentViewModelChanged;
	}
}
