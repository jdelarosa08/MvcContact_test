using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcContactos.Models
{
    public class MvcContactosContext : DbContext
    {
        public MvcContactosContext (DbContextOptions<MvcContactosContext> options)
            : base(options)
        {
        }

        public DbSet<MvcContactos.Models.Contactos> Contactos { get; set; }
    }
}
