using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kiddo.Models
{
    public class KiddoContext : DbContext
    {
        public KiddoContext (DbContextOptions<KiddoContext> options)
            : base(options)
        {
        }

        public DbSet<Kiddo.Models.Requisitador> Requisitador { get; set; }
    }
}
