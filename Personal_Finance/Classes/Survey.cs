using Personal_Finance.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Personal_Finance.Classes
{
    class Survey
    {
        public void SaveSurvey(string agebox, string retireAgeBox, string savedBox, string savePerMonth, string riskBox, string yearsBox, string amountBox)
        {
            using (System.Data.IDbConnection connection = new SqlConnection(HelperforSQLDB.ConVal("PersonalFinance")))
            {
                tblSurvey newsurvey = new tblSurvey { Age = agebox, RetirementAge = retireAgeBox, CurrentSavings = savedBox, SavingsPerMonth = savePerMonth, Risk = riskBox, YearsUntilRetirement = yearsBox, AmountSaved = amountBox};

                string SurveyResponse = @"INSERT INTO dbo.tblSurvey(Age,RetirementAge,CurrentSavings,SavingsPerMonth,Risk,YearsUntilRetirement,AmountSaved) Values('" + agebox + "','" + retireAgeBox + "', '" + savedBox + "', '" + savePerMonth + "','" + riskBox + "','" + yearsBox + "','" + amountBox + "')";

                var addsurvey = connection.Execute(SurveyResponse, "PersonalFinance");

            }
        }
    }
}