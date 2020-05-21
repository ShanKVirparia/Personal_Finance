using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Personal_Finance.Classes;

namespace Personal_Finance.Tables
{
    class tblSurvey
    {
        public string ID { get; set; }

        public string Age { get; set; }

        public string RetirementAge { get; set; }

        public string CurrentSavings { get; set; }

        public string SavingsPerMonth { get; set; }

        public string Risk { get; set; }

        public string YearsUntilRetirement { get; set; }

        public string AmountSaved { get; set; }
    }
}
