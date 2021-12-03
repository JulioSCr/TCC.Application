using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Application.GRAPHQL.Models;

namespace TCC.Application.GRAPHQL.Data
{
    public class PaisDbContext : DbContext
    {
        public PaisDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Pais> Paises { get; set; }

    }
}
