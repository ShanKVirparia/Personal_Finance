using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Personal_Finance.Classes
{
    public static class HelperforSQLDB
    {
        public static string ConVal(string PersonalFinance)
        {
            return ConfigurationManager.ConnectionStrings[PersonalFinance].ConnectionString;
        }
    }
}
