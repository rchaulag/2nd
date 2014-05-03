using LinqCrud.DataModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCrud.database
{
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext()
                : base("DefaultConnection"){}
            public DbSet<Player> Palyers { get; set; }
            public DbSet<Team> Teams { get; set; }
            public DbSet<Department> Departments { get; set; }

        }
    }
