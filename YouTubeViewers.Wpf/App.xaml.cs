using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YouTubeViewers.Wpf.Stores;
using YouTubeViewers.Wpf.ViewModels;

namespace YouTubeViewers.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ModelNavigationStore _modelNavigationStore;
        private readonly SelectedYoutubeViewerStore _selectedYoutubeViewerStore;
        public App()
        {
            _modelNavigationStore=new ModelNavigationStore();
            _selectedYoutubeViewerStore = new SelectedYoutubeViewerStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YoutubeViewersViewModel(_selectedYoutubeViewerStore)
            };
          MainWindow.Show();
          base.OnStartup(e);
        }
    }
}
