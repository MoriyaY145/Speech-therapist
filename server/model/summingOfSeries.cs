﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class summingOfSeries:baseEntity
    {
        
        public int code_series { get; set; }
        public metupal metupal { get; set; }
        public string discrabtion_first_state { get; set; }
        public DateTime date_test { get; set; }
        public string the_goals { get; set; }
        public int number_meating { get; set; }
        public int number_meating_certified { get; set; }
        public bool is_testing { get; set; }
        public string tretment { get; set; }
        public bool is_form { get; set; }
        public int num_minutes { get; set; }
        public int priceForMeating { get; set; }

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
