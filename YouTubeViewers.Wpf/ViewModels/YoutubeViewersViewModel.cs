using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.Wpf.Stores;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class YoutubeViewersViewModel:ViewModelBase
    {
        public YoutubeViewersListingModel YoutubeViewersListingModel { get;}
        public YoutubeViewersDetailsModel YoutubeViewersDetailsModel { get;}
        public ICommand AddYoutubeViewersCommand { get; }
        public YoutubeViewersViewModel(SelectedYoutubeViewerStore _selectedYoutubeViewerStore)
        {
            YoutubeViewersListingModel = new YoutubeViewersListingModel(_selectedYoutubeViewerStore);
            YoutubeViewersDetailsModel = new YoutubeViewersDetailsModel(_selectedYoutubeViewerStore);
        }
    }
}
