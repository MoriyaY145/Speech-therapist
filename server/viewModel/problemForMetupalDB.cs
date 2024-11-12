using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace viewModel
{
    public class problemForMetupalDB:baseDB
    {
        public problemForMetupalDB():base("problemForMetupal")
        {
        }
        public List<problemForMetupal> GetList()
        {
            if(list.Count==0)
            {
                Select();
            }
            return list.Cast<problemForMetupal>().ToList();
        }
        public problemForMetupal GetProblemForMetupalByCode(string codeMetupal , int codeDocuments)
        {
            return GetList().FirstOrDefault(y => y.metupal.id_metupal == codeMetupal && y.problem.code_problem== codeDocuments);
        }
        public problemForMetupal GetProblemForMetupalByNameMetupal(string Name)
        {
            return GetList().FirstOrDefault(x => x.metupal.name_metupal == Name);
        }
        protected override baseEntity CreateModel()
        {
            problemForMetupal entity = new problemForMetupal();
            entity.metupal = myDB.metupal.GetMetupalByCode(reader["metupal"].ToString());
            entity.problem = myDB.Problem.GetProblemByCode((int)reader["problem"]);
            entity.notes = reader["notes"].ToString();
            return entity;
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
