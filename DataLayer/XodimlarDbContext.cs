using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xodimlar.Models;

namespace xodimlar.DataLayer
{
    public class XodimlarDbContext:DbContext
    {
        public XodimlarDbContext(DbContextOptions<XodimlarDbContext>options):base(options)
        {

        }
        public DbSet<Xodimlar> xodimlar { get; set; }
    }
}
