using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using toys_and_games_store_api.Models;

namespace toys_and_games_store_api.Data
{
    public class toys_and_games_store_apiContext : DbContext
    {
        public toys_and_games_store_apiContext (DbContextOptions<toys_and_games_store_apiContext> options)
            : base(options)
        {
        }

        public DbSet<toys_and_games_store_api.Models.Product> Product { get; set; }
    }
}
