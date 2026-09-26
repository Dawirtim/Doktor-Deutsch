using System.Windows.Controls;

namespace Doktor_Deutsch
{
    /// <summary>
    /// Logika interakcji dla klasy LessonMaterialSelector.xaml
    /// </summary>
    public partial class LessonMaterialSelector : UserControl
    {
        private readonly MainWindow _mainWindow;
        public LessonMaterialSelector(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
    }
}
