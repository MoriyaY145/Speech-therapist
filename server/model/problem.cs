﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class problem:baseEntity
    {
        public int code_problem { get; set; }
        public string name_problem { get; set; }

        public override string[] GetKeyFields()
        {
            throw new NotImplementedException();
        }

        public override string GetTableName()
        {
            throw new NotImplementedException();
        }
    }
}
