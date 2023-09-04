using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class EditYoutubeViewerViewModel
    {
        public YoutubeViewersDetailsFormViewModel YoutubeViewersDetailsFormViewModel { get; }

        public EditYoutubeViewerViewModel()
        {
            YoutubeViewersDetailsFormViewModel = new YoutubeViewersDetailsFormViewModel();
        }
    }
}
