using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class YoutubeViewersListingItemViewModel:ViewModelBase
    {
        public string Username { get; }
        public ICommand DeleteCommand { get; }
        public ICommand EditCommand { get; }
        public YoutubeViewersListingItemViewModel(string username)
        {
            Username = username;
        }
    }
}
