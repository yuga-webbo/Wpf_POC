using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class AddYoutubeViewerViewModel
    {
        public YoutubeViewersDetailsFormViewModel YoutubeViewersDetailsFormViewModel { get; }

        public AddYoutubeViewerViewModel()
        {
            YoutubeViewersDetailsFormViewModel = new YoutubeViewersDetailsFormViewModel();
        }
    }
}
