using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.Wpf.Models;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class YoutubeViewersListingItemViewModel:ViewModelBase
    {
        public YouTubeViewer YouTubeViewer;
        public string Username =>YouTubeViewer.Username;
        public ICommand DeleteCommand { get; }
        public ICommand EditCommand { get; }
        public YoutubeViewersListingItemViewModel(YouTubeViewer youTubeViewer)
        {
            this.YouTubeViewer = youTubeViewer;
        }
    }
}
