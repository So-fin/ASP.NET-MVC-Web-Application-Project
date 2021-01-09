using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Employeecontext : DbContext
    {
        public DbSet<employee> Emp { get; set; }
        public DbSet<Members> userset { get; set; }
        public DbSet<Feedback> dbset { get; set; }
    }
}