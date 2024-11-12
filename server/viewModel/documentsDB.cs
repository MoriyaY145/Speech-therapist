using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace viewModel
{
   public class documentsDB : baseDB
    {
        public documentsDB() : base("documents")
        {
        }
        public List<documents> GetList()
        {
            if(list.Count()==0)
            {
                Select();
            }
            return list.Cast<documents>().ToList();
        }
        public documents GetDocumentsByCode(int code)
        {
            return GetList().FirstOrDefault(x => x.code_document == code);
        }
        protected override baseEntity CreateModel()
        {
            documents entity = new documents();
            entity.code_document = (int)reader["code_document"];
            entity.metupal = myDB.metupal.GetMetupalByCode(reader["id_metupal"].ToString());
            entity.name_document = reader["name_document"].ToString();
            entity.location_document = reader["location_document"].ToString();
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
