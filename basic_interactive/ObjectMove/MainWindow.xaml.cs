using System.Windows;
using System.Windows.Input;

namespace ObjectMove
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel ViewModel => (MainViewModel)DataContext;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
                ViewModel.Move("Left");
            else if (e.Key == Key.Right)
                ViewModel.Move("Right");
            else if (e.Key == Key.Up)
                ViewModel.Move("Up");
            else if (e.Key == Key.Down)
                ViewModel.Move("Down");
        }
    }
}