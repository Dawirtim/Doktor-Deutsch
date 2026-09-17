using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
