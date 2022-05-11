using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Contexts.Restaurtant
{
    public class RestaurantConfiguration:DbMigrationsConfiguration<RestaurantContext>
    {
        public RestaurantConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }
    }
}
