using ReactiveUiApp01.ViewModels;
using ReactiveUiApp01.Views;
using System.Windows;

namespace ReactiveUiApp01
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var vm = new MainViewModel();
            var v = new MainView
            {
                DataContext = vm
            };

            v.ShowDialog();
        }
    }

}
