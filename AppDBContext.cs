using CodeFirstDB.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstDB
{
    public class AppDBContext : DbContext
    {
        
        public AppDBContext()
            : base("name=AppDBContext")
        {
        }

       
         public DbSet<AntarcticPopulations> AntarcticPopulations { get; set; }
    }

}