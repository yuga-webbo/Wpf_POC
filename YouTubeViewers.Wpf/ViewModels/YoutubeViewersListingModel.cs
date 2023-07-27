using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Wpf.Models;
using YouTubeViewers.Wpf.Stores;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class YoutubeViewersListingModel:ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        private readonly ObservableCollection<YoutubeViewersListingItemViewModel> _youtubeViewersListingItemViewModel;
        public IEnumerable<YoutubeViewersListingItemViewModel> YoutubeViewersListingItemViewModel =>
            _youtubeViewersListingItemViewModel;
        private YoutubeViewersListingItemViewModel _selectedYoutubeViewersListingItemViewModel;
        public YoutubeViewersListingItemViewModel SelectedYoutubeViewersListingItemViewModel
        {
            get
            {
                return _selectedYoutubeViewersListingItemViewModel;
            }
            set
            {
                _selectedYoutubeViewersListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedYoutubeViewersListingItemViewModel));
                _selectedYoutubeViewerStore.SelectedYouTubeViewer = SelectedYoutubeViewersListingItemViewModel?.YouTubeViewer;
            }
        }
        public YoutubeViewersListingModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            this._selectedYoutubeViewerStore = selectedYoutubeViewerStore;
            _youtubeViewersListingItemViewModel = new ObservableCollection<YoutubeViewersListingItemViewModel>();

            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YouTubeViewer("Sean",true,false)));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YouTubeViewer("Abba", false, false)));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YouTubeViewer("Derta", true, true)));
            _youtubeViewersListingItemViewModel.Add(new YoutubeViewersListingItemViewModel(new YouTubeViewer("Mikkl", false, true)));
        }
    }
}
