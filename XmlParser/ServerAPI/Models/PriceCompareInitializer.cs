using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServerAPI.Models
{
    public class PriceCompareInitializer: DropCreateDatabaseIfModelChanges<PriceCompareDbContext>
    {
        public override void InitializeDatabase(PriceCompareDbContext context)
        {
            base.InitializeDatabase(context);
        }
    }
}