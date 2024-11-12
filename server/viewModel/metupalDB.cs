using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace viewModel
{
    public class metupalDB : baseDB
    {
        public metupalDB() : base("metupal")
        {
        }
        public List<metupal> GetList()
        {
            if(list.Count()==0)
            {
                Select();
            }
            return list.Cast<metupal>().ToList();
        }
        public metupal GetMetupalByCode(string code)
        {
            return GetList().FirstOrDefault(x => x.id_metupal == code);
        }

        protected override baseEntity CreateModel()
        {
            metupal entity = new metupal();
            entity.id_metupal = reader["id_metupal"].ToString();
            entity.name_metupal = reader["name_metupal"].ToString();
            entity.date_birth =reader["date_birth"].ToString();
            entity.phone_number = reader["phone_number"].ToString();
            entity.reason_turning = reader["reason_turning"].ToString();
            entity.communication_date = reader["communication_date"].ToString();
            entity.notes = reader["notes"].ToString();
            entity.kupat_cholim = reader["kupat_cholim"].ToString();
            entity.status = reader["status"].ToString();
            return entity;
        }

        public List<metupal> GetMetupalByStatusAndKupa( string s1, string s2)
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
    }
}