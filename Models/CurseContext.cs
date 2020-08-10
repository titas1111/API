using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CurseContext: DbContext
    {
        public CurseContext(DbContextOptions<CurseContext> options): base(options)
        {

        }

        public DbSet<Curse> Curses { get; set; }
    }
}
