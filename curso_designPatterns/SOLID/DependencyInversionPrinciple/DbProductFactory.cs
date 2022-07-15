using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID.DependencyInversionPrinciple
{
    class DbProductFactory
    {
        public static DbProductFactory Create()
        {
            if (ConfigurationManager.AppSettings["DB"]=="SQLSERVER")
            {
                return new SqlServerDbProduct();
            }
            else
            {
                return new MongoDbProduct();
            }
        }
    }
}
