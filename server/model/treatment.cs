using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
   public class treatment:baseEntity
    {
        public int code_meating { get; set; }
        public metupal code_metupal { get; set; }
        public summingOfSeries code_series { get; set; }
        public int num_treatment { get; set; }
        public DateTime date_treatment { get; set; }
        public string the_treatment { get; set; }
        public string hour_treatment { get; set; } 
        public string status_treatment { get; set; }
        public bool is_paid { get; set; }
        public string how_paid { get; set; }
        public override string[] GetKeyFields()
        {
            return new string[] { "code_meating" }; 
        }

        public override string GetTableName()
        {
            throw new NotImplementedException();
        }
    }
    
}
