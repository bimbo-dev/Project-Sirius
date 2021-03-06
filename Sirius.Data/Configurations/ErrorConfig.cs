﻿using Sirius.Data.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Data.Configurations
{
    public class ErrorConfig : EntityBaseConfig<ErrorBO>
    {
        public ErrorConfig()
        {
            Property(e => e.StackTrace).IsOptional().IsMaxLength();
        }
    }
}
