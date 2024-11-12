using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class documents:baseEntity
    {
        public int code_document { get; set; }
        public metupal metupal { get; set; }
        public string name_document { get; set; }
        public string location_document { get; set; }

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
