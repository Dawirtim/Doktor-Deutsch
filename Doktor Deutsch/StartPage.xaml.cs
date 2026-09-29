using System.Windows;
using System.Windows.Controls;

namespace Doktor_Deutsch
{
    /// <summary>
    /// Logika interakcji dla klasy StartPage.xaml
    /// </summary>
    public partial class StartPage : UserControl
    {
        private readonly MainWindow _mainWindow;
        public StartPage(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void NewLesson_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.LessonMaterialSelector();
        }

        private void Retake_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.RetakeLessonSelector();
        }
    }
}
