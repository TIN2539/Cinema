using Cinema.Data.Stub;
using Cinema.Domain;
using Cinema.Presentation.Wpf.ViewModels;
using Cinema.Presentation.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Cinema.Presentation.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var dataService = new StubCinemaDataService();
            var cinemaManager = new CinemaManager(dataService);
            var viewModel = new MainViewModel(cinemaManager);
            var view = new MainView(viewModel);

            view.Show();
        }
    }
}
