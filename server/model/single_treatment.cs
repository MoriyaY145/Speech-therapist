using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class single_treatment:baseEntity
    {
        public int code_single_treatment { get; set; }
        public metupal metupal { get; set; }
        public DateTime date_single_treatment { get; set; }
        public DateTime hour { get; set; }
        public int num_minutes { get; set; }
        public int sum_of_payment { get; set; }
        public string how_paid { get; set; }
        public string the_treatment { get; set; }
        public string status { get; set; }
        public bool is_paid { get; set; }
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
