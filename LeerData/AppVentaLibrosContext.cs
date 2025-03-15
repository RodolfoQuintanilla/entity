using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaLibrosContext : DbContext
    {
        //private const string connectionString = @"Data Source = xibalba\rqm; Initial Catalog= LobrosWeb; Integrated Segurity= True";
        // string connectionString = "Data Source=xibalba\rqm; Initial Catalog=LibrosWeb; Integrated Security=True;";

       /// private const string connectionString = @"Data Source=XIBALBA\SQLEXPRESS; Initial Catalog=LibrosWeb2; Integrated Security=True;";
       
  
        private const string connectionString = @"Data Source=xibalba Catalog=LibrosWeb2;Integrated Security=True";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Libro> Libro { get; set; }

    }
}