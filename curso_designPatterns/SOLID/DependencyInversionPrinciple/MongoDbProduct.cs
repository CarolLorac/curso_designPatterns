using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID.DependencyInversionPrinciple
{
    class MongoDbProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDB: Id {id} reconhecido!!";
        }

    }
}
