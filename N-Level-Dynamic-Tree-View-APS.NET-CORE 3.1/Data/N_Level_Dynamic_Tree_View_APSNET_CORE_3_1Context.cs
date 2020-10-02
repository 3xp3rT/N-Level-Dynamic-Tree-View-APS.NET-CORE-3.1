using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using N_Level_Dynamic_Tree_View_APS.NET_CORE_3._1.Models;

namespace N_Level_Dynamic_Tree_View_APS.NET_CORE_3._1.Data
{
    public class N_Level_Dynamic_Tree_View_APSNET_CORE_3_1Context : DbContext
    {
        public N_Level_Dynamic_Tree_View_APSNET_CORE_3_1Context (DbContextOptions<N_Level_Dynamic_Tree_View_APSNET_CORE_3_1Context> options)
            : base(options)
        {
        }

        public DbSet<N_Level_Dynamic_Tree_View_APS.NET_CORE_3._1.Models.Account> Account { get; set; }
    }
}
