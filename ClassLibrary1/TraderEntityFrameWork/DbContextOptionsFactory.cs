using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace TraderEntityFrameWork
{
    public class DbContextOptionsFactory : IDesignTimeDbContextFactory<TraderDbContext>
    {
        public TraderDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<TraderDbContext>();
            options.UseSqlServer(ConnectionString);
            return new TraderDbContext(options.Options);
        }



        #region
        public string ConnectionString {  get{ return connectionString; }private set { } }

        private const string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Database = WpfTranzactions; Persist Security Info = false; User ID = 'sa'; Password = 'Ghbdtn010102'; MultipleActiveResultSets = True; Trusted_Connection = False;";

        #endregion
    }
}
