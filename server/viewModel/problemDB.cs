using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace viewModel
{
    public class problemDB : baseDB
    {
        public problemDB() : base("problem")
        {
        }
        public List<problem> GetList()
        {
            if(list.Count()==0)
            {
                Select();
            }
            return list.Cast<problem>().ToList();
        }
        public problem GetProblemByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.code_problem == code);
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
            problem entity = new problem();
            entity.code_problem = (int)reader["code_problem"];
            entity.name_problem = reader["name_problem"].ToString();
            return entity;
        }

        protected override string CreateUpdateCommand(baseEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
