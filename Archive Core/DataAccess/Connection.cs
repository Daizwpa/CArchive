using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archive_Core.DataAccess
{
    public  class Connection: DbContext
    {
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Folder> folders { get; set; }
        public virtual DbSet<File> files { get; set; }
        private string serverName;
        private string databaseName;

        public Connection(string serverName=".", string databaseName= "datasetArchive") : base()
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            optionsBuilder.UseSqlServer($"Server={serverName};Database={databaseName};Trusted_Connection=True;");

            

            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
