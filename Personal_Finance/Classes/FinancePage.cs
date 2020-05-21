using Dapper;
using Personal_Finance.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance.Classes
{
    class FinancePage
    {
        public void SaveNetWorth(string emailaddress,string assetTotal, string debtTotal, string netWorth)
        {
            using (System.Data.IDbConnection connection = new SqlConnection(HelperforSQLDB.ConVal("PersonalFinance")))
            {
                tblFinance saveNetWorth = new tblFinance { EmailAddress = emailaddress, AssetTotal = assetTotal, DebtTotal = debtTotal, NetWorth = netWorth };

                string insertFinance = @"INSERT INTO dbo.tblFinance(EmailAddress,AssetTotal,DebtTotal,NetWorth) Values('" + emailaddress + "','" + assetTotal + "','" + debtTotal + "', '" + netWorth + "')";

                var addsurvey = connection.Execute(insertFinance, "PersonalFinance");

            }
        }

    }
}
