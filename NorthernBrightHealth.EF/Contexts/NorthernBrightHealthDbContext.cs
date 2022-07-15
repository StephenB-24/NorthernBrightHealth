using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NorthernBrightHealth.Shared.Models;

namespace NorthernBrightHealth.EF.Contexts
{
    public class NorthernBrightHealthDbContext : DbContext
    {
        public virtual DbSet<Patient> Patients { get; set; }
    }
}
