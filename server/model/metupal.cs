using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
     public class metupal:baseEntity
    {
        public string id_metupal { get; set; }
        public string name_metupal { get; set; }
        public string date_birth { get; set; }
        public string phone_number { get; set; }
        public string reason_turning { get; set; }
        public string communication_date { get; set; }
        public string notes { get; set; }
        public string kupat_cholim { get; set; }
        public string status { get; set; }

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
