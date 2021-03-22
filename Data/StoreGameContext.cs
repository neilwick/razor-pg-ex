using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_pg_ex.Models;

    public class StoreGameContext : DbContext
    {
        public StoreGameContext (DbContextOptions<StoreGameContext> options)
            : base(options)
        {
        }

        public DbSet<razor_pg_ex.Models.Game> Game { get; set; }
    }
