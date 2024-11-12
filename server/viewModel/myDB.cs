using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viewModel
{
   public class myDB
    {
        public static metupalDB metupal = new metupalDB();
        public static documentsDB documents = new documentsDB();
        public static problemDB Problem = new problemDB();
        public static problemForMetupalDB ProblemForMetupal = new problemForMetupalDB();
        public static single_treatmentDB Single_Treatment = new single_treatmentDB();
        public static summingOfSeriesDB SummingOfSeries = new summingOfSeriesDB();
        public static treatmentDB treatment = new treatmentDB();
    }
}
