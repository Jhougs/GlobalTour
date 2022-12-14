using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entidiades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Lugar> Lugar { get; set; }
    }
}