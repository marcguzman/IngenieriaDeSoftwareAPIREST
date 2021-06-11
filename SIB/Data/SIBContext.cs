using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIB.Models;

namespace SIB.Data
{
    public class SIBContext : DbContext
    {
        public SIBContext (DbContextOptions<SIBContext> options)
            : base(options)
        {
        }

        public DbSet<SIB.Models.SIB_Usuario> UserModel { get; set; }

        public DbSet<SIB.Models.SIB_Ccuenta> SIB_Ccuenta { get; set; }
    }
}
