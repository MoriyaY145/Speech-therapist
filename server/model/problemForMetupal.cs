using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class problemForMetupal : baseEntity
    {
        public metupal metupal { get; set; }
        public problem problem { get; set; }
        public string notes { get; set; }
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
