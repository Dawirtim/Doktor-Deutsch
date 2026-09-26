using System.Windows;
using System.Windows.Controls;

namespace Doktor_Deutsch
{
    /// <summary>
    /// Logika interakcji dla klasy Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        private readonly MainWindow _mainWindow;
        public Header(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.StartPage();
        }

        private void MinimalizeWindow_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizeWindow_Click(object sender, RoutedEventArgs e)
        {
            if (_mainWindow.WindowState == WindowState.Maximized)
            {
                _mainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                _mainWindow.WindowState = WindowState.Maximized;
            }
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Close();
        }

    }
}
