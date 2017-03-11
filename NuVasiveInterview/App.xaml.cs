using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NuVasiveInterview.View;
using NuVasiveInterview.ViewModel;

namespace NuVasiveInterview
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NuVasiveView view = new NuVasiveView();
            NuVasiveViewModel viewModel = new NuVasiveViewModel();
            view.DataContext = viewModel;
            view.Show();

        }
    }
}
