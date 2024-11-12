using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace viewModel
{
    public class treatmentDB:baseDB
    {
        public treatmentDB():base("treatment")
        {
        }
        public List<treatment> GetList()
        {
            if(list.Count()==0)
            {
                Select();
            }
            return list.Cast<treatment>().ToList();
        }
        public treatment GetTreatmentByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.code_meating == code);
        }

        public void AddTreatment(treatment t)
        {
            throw new NotImplementedException();
        }

        protected override baseEntity CreateModel()
        {
            treatment entity = new treatment();
            entity.code_meating = (int)reader["Code_meating"];
            entity.code_metupal = myDB.metupal.GetMetupalByCode(reader["code_metupal"].ToString());
            entity.num_treatment = (int)reader["Num_treatment"];
            entity.date_treatment = Convert.ToDateTime(reader["Date_treatment"]);
            entity.the_treatment = reader["The_treatment"].ToString();
            entity.hour_treatment = reader["Hour_treatment"].ToString();
            entity.status_treatment = reader["status_ treatment"].ToString();
            entity.is_paid = (bool)reader["Is_paid"];
            entity.how_paid = reader["How_paid"].ToString();
            entity.code_series = myDB.SummingOfSeries.GetSummingOfSeriesByCode((int)reader["code_series"]);
            return entity;
        }

        public void DeleteTreatment(treatment t3)
        {
            throw new NotImplementedException();
        }

        protected override string CreateInsertCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }

        protected override string CreateUpdateCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }

        protected override string CreateDeletedCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }

        //protected override string CreateInsertCommand(baseEntity item)
        //{
        //    throw new NotImplementedException();
        //}

        //protected override string CreateUpdateCommand(baseEntity item)
        //{
        //    throw new NotImplementedException();
        //}

        //protected override string CreateDeletedCommand(baseEntity item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
