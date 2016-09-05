using System.Data.Entity;
using PriceCompare.DAL.Migrations;

namespace PriceCompare.DAL.Data
{
    public class PriceCompareInitializer: MigrateDatabaseToLatestVersion<PriceCompareDbContext,Configuration>
    {
        public override void InitializeDatabase(PriceCompareDbContext context)
        {
             base.InitializeDatabase(context);
        }
    }
}