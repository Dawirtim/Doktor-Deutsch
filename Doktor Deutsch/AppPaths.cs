using System.IO;

namespace Doktor_Deutsch
{
    public static class AppPaths
    {
        public static string appFolder { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DoktorDeutsch", "DoktorDeutsch");
        public static string dbPath { get; } = Path.Combine(appFolder, "LocalData.db");
        static AppPaths()
        {
            Directory.CreateDirectory(appFolder);
        }
    }
}
