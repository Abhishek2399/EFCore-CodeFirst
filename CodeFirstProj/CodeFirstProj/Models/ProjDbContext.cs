using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstProj.Models
{
    // 

    /// <summary>
    /// DbContext contains Sessions with Database 
    /// Responsible for communication with Db and Server 
    /// </summary>
    public class ProjDbContext : DbContext // ProjDbConext class should extend DbContext 
    {
        /// <summary>
        /// DbSet Property for collection of Records{table} of Employee
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }

        public ProjDbContext()
        {

        }

        /// <summary>
        /// For Configuring Server name and Database name 
        /// Param->optionBuilder is used for configure Database
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server = NOOB; Database = EFCoreCodeFirstDb2.0; Trusted_connection = true"); // used to configure database 
            // takes connection string as a parameter 
            // if database doesn't exist this will create a new database
        }

        // Step 2 -> define models i.e. is ModelClasses which is the entities in the db

        // As we need to migrate this information 
        // Only after migration this will create Database
        // pkg manager console 
        // Migration Command is used for this




    }
}
