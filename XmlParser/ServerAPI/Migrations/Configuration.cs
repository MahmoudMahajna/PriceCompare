using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ServerAPI.Models;

namespace ServerAPI.Migrations
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