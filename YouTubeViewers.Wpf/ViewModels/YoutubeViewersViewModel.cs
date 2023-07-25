using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class YoutubeViewersViewModel:ViewModelBase
    {
        public YoutubeViewersListingModel YoutubeViewersListingModel { get;}
        public YoutubeViewersDetailsModel YoutubeViewersDetailsModel { get;}
        public ICommand AddYoutubeViewersCommand { get; }
        public YoutubeViewersViewModel()
        {
            YoutubeViewersListingModel = new YoutubeViewersListingModel();
            YoutubeViewersDetailsModel = new YoutubeViewersDetailsModel();
        }
    }
}
