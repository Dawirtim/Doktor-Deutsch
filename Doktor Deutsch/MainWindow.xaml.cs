using Doktor_Deutsch.Data;
using Doktor_Deutsch.Models;
using System.Collections.ObjectModel;
using System.Windows;
namespace Doktor_Deutsch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Word>? Words { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new StartPage(this);
            Header.Content = new Header(this);
            StateChanged += MainWindow_StateChanged;
            using var db = new LocalDatabase();
            db.Database.EnsureCreated();
            var wordsFromDb = db.Words.ToList();
            Words = new ObservableCollection<Word>(wordsFromDb);
        }
        public void LessonMaterialSelector()
        {
            MainContent.Content = new LessonMaterialSelector(this);
        }
        public void RetakeLessonSelector()
        {
            MainContent.Content = new LessonMaterialSelector(this);
        }
        private void MainWindow_StateChanged(object? sender, EventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                RootGrid.Margin = new Thickness(7);
            }
            else
            {
                RootGrid.Margin = new Thickness(0);
            }
        }
        public void AddWord(Word word)
        {
            using var db = new LocalDatabase();
            db.Words.Add(word);
            db.SaveChanges();
            Words.Add(word);
        }
        public void DeletWord(Word word)
        {
            using var db = new LocalDatabase();
            db.Words.Remove(word);
            db.SaveChanges();
            Words.Remove(word);
        }
    }
}