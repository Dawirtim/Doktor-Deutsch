using Doktor_Deutsch.Models;
using Microsoft.EntityFrameworkCore;
namespace Doktor_Deutsch.Data
{
    internal class Database : DbContext
    {
        public DbSet<Word> Words { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=lekcje.db");
        }
    }
}
