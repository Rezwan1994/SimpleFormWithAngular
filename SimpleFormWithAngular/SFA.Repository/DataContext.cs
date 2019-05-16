using SFA.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SFA.Repository
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        private DataContext() { }
        public static DataContext context = null;
        public static DataContext getInstance()
        {
            if (context == null)
            {
                context = new DataContext();
                return context;
            }
            return context;
        }
    }
}
