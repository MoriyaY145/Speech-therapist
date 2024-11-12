using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viewModel
{
    public class summingOfSeriesDB : baseDB
    {
        public summingOfSeriesDB() : base("summingOfSeries")
        {
        }
        public List<summingOfSeries> GetList()
        {
            if (list.Count == 0)
                Select();
            return list.Cast<summingOfSeries>().ToList();
        }
        public summingOfSeries GetSummingOfSeriesByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.code_series == code);
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
            summingOfSeries entity = new summingOfSeries();
            entity.code_series = (int)reader["Code_series"];
            entity.metupal =myDB.metupal.GetMetupalByCode(reader["id_metupal"].ToString());
            entity.date_test = Convert.ToDateTime(reader["Date_test"]);
            entity.the_goals = reader["The_goals"].ToString();
            entity.number_meating = (int)reader["Number_meating"];
            entity.number_meating_certified = (int)reader["Number_meating_certified"];
            entity.is_testing = (bool)reader["Is_testing"];
            entity.tretment = reader["treatment"].ToString();
            entity.is_form = (bool)reader["Is_form"];
            entity.num_minutes = (int)reader["Num_minutes"];
            entity.priceForMeating = (int)reader["PriceForMeating"];
            entity.discrabtion_first_state = reader["discrabtion_first_stste"].ToString();

            return entity;
        }

        protected override string CreateUpdateCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }

        //protected override string CreateUpdateCommand(baseEntity item)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

