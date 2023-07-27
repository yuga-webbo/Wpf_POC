using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Wpf.Models;
using YouTubeViewers.Wpf.Stores;

namespace YouTubeViewers.Wpf.ViewModels
{
    public class YoutubeViewersDetailsModel : ViewModelBase
    {
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        private YouTubeViewer SelectedYouTubeViewer => _selectedYoutubeViewerStore.SelectedYouTubeViewer;
        public bool HasSelectedYouTubeViewer => SelectedYouTubeViewer != null;
        public string Username => SelectedYouTubeViewer?.Username ?? "Unknown";
        public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false)?"Yes":"No";
        public string IsMemberDisplay => (SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No";
        public YoutubeViewersDetailsModel(SelectedYoutubeViewerStore selectedYoutubeViewerStore)
        {
            _selectedYoutubeViewerStore=selectedYoutubeViewerStore;
            _selectedYoutubeViewerStore.SelectedYouTubeViewerChanged += SelectedYoutubeViewerStore_SelectedYouTubeViewerChanged;
        }
        protected override void Dispose()
        {
            _selectedYoutubeViewerStore.SelectedYouTubeViewerChanged -= SelectedYoutubeViewerStore_SelectedYouTubeViewerChanged;
            base.Dispose();
        }

        private void SelectedYoutubeViewerStore_SelectedYouTubeViewerChanged()
        {
            OnPropertyChanged(nameof(HasSelectedYouTubeViewer));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
        }
    }
}
