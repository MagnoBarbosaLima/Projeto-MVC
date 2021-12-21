using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoRecodeProMVC.Models;

namespace ProjetoRecodeProMVC.Data
{
    public class ProjetoRecodeProMVCContext : DbContext
    {
        public ProjetoRecodeProMVCContext (DbContextOptions<ProjetoRecodeProMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoRecodeProMVC.Models.Cliente> Cliente { get; set; }
    }
}
