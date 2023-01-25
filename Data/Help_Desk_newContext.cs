using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Help_Desk_new.Models;

namespace Help_Desk_new.Data
{
    public class Help_Desk_newContext : DbContext
    {
        public Help_Desk_newContext (DbContextOptions<Help_Desk_newContext> options)
            : base(options)
        {
        }

        public DbSet<Help_Desk_new.Models.Ticket> Ticket { get; set; } = default!;
    }
}
