using KT16_SkalochkinFedor_ISP_321_MasterFloor.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT16_SkalochkinFedor_ISP_321_MasterFloor.Classes
{
    public class Context:DbContext
    {
        public static Context context;
        public DbSet<PartnersImport> PartnersImport { get; set; }
        public static Context GetContext()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }
        public Context() : base("name=KT16_SkalochkinFedor_ISP321_MasterFloorEntities")
        {

        }
    }
}
