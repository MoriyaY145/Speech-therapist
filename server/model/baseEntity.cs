﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public abstract class baseEntity
    {
        public abstract string GetTableName();
        public abstract string[] GetKeyFields();
    }
}
