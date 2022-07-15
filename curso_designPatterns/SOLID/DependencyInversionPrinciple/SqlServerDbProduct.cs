using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID.DependencyInversionPrinciple
{
    class SqlServerDbProduct
    {
        public string GetProductById(string id)
        {
            return $"SQlServer: Id {id} reconhecido!!";
        }
    }
}
