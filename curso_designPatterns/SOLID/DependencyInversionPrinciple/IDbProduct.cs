﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID.DependencyInversionPrinciple
{
    interface IDbProduct
    {
        string GetProductByID(string id);
    }
}
