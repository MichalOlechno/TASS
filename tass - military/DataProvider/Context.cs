using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tass___military.DataProvider
{
    class Context : DbContext
    {
        public Context():base("TASS_militaryEntities")
        {

        }
        public DbSet<military_full> MilitaryContext { get; set; }
        public DbSet<alliance_with_duplicates> AlliancesContext { get; set; }
    }
  
}
