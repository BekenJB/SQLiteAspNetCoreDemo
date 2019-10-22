using Microsoft.EntityFrameworkCore;

namespace SQLiteAspNetCoreDemo
{
    public class SQLiteDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\JeanB\source\repos\SQLiteAspNetCoreDemo\SQLiteAspNetCoreDemo\sqlitedemo.db");
    }
}
