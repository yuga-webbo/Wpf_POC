using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YouTubeViewers.Wpf.Models;

namespace YouTubeViewers.Wpf.Stores
{
    public class SelectedYoutubeViewerStore
    {
        private YouTubeViewer _selectedyouTubeViewer;
        public YouTubeViewer SelectedYouTubeViewer
        {
            get {
                return _selectedyouTubeViewer;
            }
            set {
                _selectedyouTubeViewer = value;
                SelectedYouTubeViewerChanged?.Invoke();
            }
        }
        public event Action SelectedYouTubeViewerChanged;
    }
}
