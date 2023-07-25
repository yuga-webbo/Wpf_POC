using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class YoutubeViewersListingModel:ViewModelBase
    {
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModel;
        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModel =>
            _youtubeViewersListingItemViewModel;
        public YoutubeViewersListingModel()
        {
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("Sean"));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("Meas"));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("terta"));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel("Bianca"));
        }
    }
}
