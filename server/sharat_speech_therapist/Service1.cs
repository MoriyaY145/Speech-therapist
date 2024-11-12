using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using model;
using viewModel;

namespace sharat_speech_therapist
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int AddMetupal(metupal m3)
        {
             myDB.metupal.Add(m3);
             return myDB.metupal.SaveChanges();
        }

        public void AddTreatment(treatment t1)
        {
             myDB.treatment.Add(t1);
            myDB.metupal.SaveChanges();
        }

        public void DeleteMetupal(metupal m2)
        {
             myDB.metupal.Deleted(m2);
            myDB.metupal.SaveChanges();
        }

        public void DeleteTreatment(treatment t3)
        {
             myDB.treatment.Deleted(t3);
            myDB.metupal.SaveChanges();
        }

        public List<metupal> GetAllMetupal()
        {
            var t = myDB.metupal.GetList();
            return t;
        }

        public List<metupal> GetMetupalByStatusAndKupa(string s1 , string s2)
        {
            return myDB.metupal.GetMetupalByStatusAndKupa( s1,  s2) ;
        }

        public List<treatment> GetTreatmentByName(string s3)
        {
            throw new NotImplementedException();
        }

        public void UpdateMetupal(metupal m1)
        {
            throw new NotImplementedException();
        }

        public void UpdateTreatment(treatment t2)
        {
            throw new NotImplementedException();
        }

        public List<treatment> GetTreatment()
        {
            return myDB.treatment.GetList();
        }
        public List<problem> GetProblems()
        {
            return myDB.Problem.GetList();
        }

        public problemForMetupal GetProblemForMetupalByNameMetupal(string Name)
        {
            var t = myDB.ProblemForMetupal.GetProblemForMetupalByNameMetupal(Name);
            return t;
        }
    }
}
