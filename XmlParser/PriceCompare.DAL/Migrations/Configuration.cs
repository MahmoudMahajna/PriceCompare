using System.Data.Entity.Migrations;
using PriceCompare.DAL.Data;

namespace PriceCompare.DAL.Migrations
{
    public class Configuration:DbMigrationsConfiguration<PriceCompareDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PriceCompareDbContext context)
        {
            
            base.Seed(context);
        }
    }
}