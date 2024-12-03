using SQLite;

namespace CoolApp.Data
{
    public class Constants
    {
        private const string DBFileName = "CoolApp.db";

        public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;

        public static string DBPath
        {
            get
            {
                // return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBFileName);
            }
        }
    }
}