using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoldsSimpleWebApp.Models;

namespace HoldsSimpleWebApp.Data
{
    public class HoldsSimpleWebAppContext : DbContext
    {
        public HoldsSimpleWebAppContext (DbContextOptions<HoldsSimpleWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<HoldsSimpleWebApp.Models.OrderHold> OrderHold { get; set; }
    }
}
