using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace host_speech_therapist
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost service = new ServiceHost(typeof(sharat_speech_therapist.Service1));
            service.Open();

            Console.Read();
        }
    }
}
