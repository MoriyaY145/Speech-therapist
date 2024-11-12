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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //שליפה של טבלת מטופל
        [OperationContract]
        List<metupal> GetAllMetupal();
        [OperationContract]
        void UpdateMetupal( metupal m1);
        [OperationContract]
        void DeleteMetupal( metupal m2);
        [OperationContract]
        List<metupal> GetMetupalByStatusAndKupa(string s1,string s2);
        [OperationContract]
        List<treatment> GetTreatmentByName(string s3);
        [OperationContract]
        int AddMetupal(metupal m3);
        [OperationContract]
        void AddTreatment(treatment t1);
        [OperationContract]
        void UpdateTreatment(treatment t2);
        [OperationContract]
        void DeleteTreatment(treatment t3);
        [OperationContract]
        List<treatment> GetTreatment();
        [OperationContract]
        List<problem> GetProblems();
        [OperationContract]
        problemForMetupal GetProblemForMetupalByNameMetupal(string Name);
    }
}
