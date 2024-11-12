using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace viewModel
{
   public class single_treatmentDB:baseDB
    {
        public single_treatmentDB():base("single_treatment")
        {
        }
        public List<single_treatment> GetList()
        {
            return list.Cast<single_treatment>().ToList();
        }
        public single_treatment GetSingleTreatmentByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.code_single_treatment == code);
        }

        protected override string CreateDeletedCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }

        protected override string CreateInsertCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }

        protected override baseEntity CreateModel()
        {
            single_treatment entity = new single_treatment();
            entity.code_single_treatment = (int)reader["code_single_treatment"];
            entity.metupal = myDB.metupal.GetMetupalByCode(reader["metupal"].ToString());
            entity.date_single_treatment = Convert.ToDateTime(reader["date_single_treatment"]);
            entity.hour = Convert.ToDateTime(reader["hour"]);
            entity.num_minutes = (int)reader["num_minutes"];
            entity.sum_of_payment = (int)reader["sum_of_payment"];
            entity.how_paid = reader["how_paid"].ToString();
            entity.the_treatment = reader["the_treatment"].ToString();
            entity.status = reader["status"].ToString();
            entity.is_paid = (bool)reader["is_paid"];
            return entity;

        }

        protected override string CreateUpdateCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
