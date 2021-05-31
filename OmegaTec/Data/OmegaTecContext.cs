using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OmegaTec.Models;

namespace OmegaTec.Data
{
    public class OmegaTecContext : DbContext
    {
        public OmegaTecContext (DbContextOptions<OmegaTecContext> options)
            : base(options)
        {
        }

        public DbSet<OmegaTec.Models.Cliente> Cliente { get; set; }

        public DbSet<OmegaTec.Models.Tarefa> Tarefa { get; set; }
    }
}
