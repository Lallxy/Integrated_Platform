using Integrated_Platform_App.Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.API.DAO.DateBaseConnect
{
    public class App_DbContext : DbContext
    {
        string Connect_string = "Data Source = .; Initial Catalog =Integrated_Platform_App_DateBase ; User ID = sa;Password =123456;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connect_string);
        }
        public DbSet<User> User { get; set; } 
        public DbSet<MenuBar> MenuBar { get; set; }
        public DbSet<TaskBar> TaskBar { get; set; }

    }
}
