using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Personal_Finance.Tables;
using System.Configuration;


namespace Personal_Finance.Classes
{
    class DataAccess
    {
        public void AddNewUser(string firstName, string lastName, string emailAddress, string password)
        {
            using (IDbConnection connection = new SqlConnection(HelperforSQLDB.ConVal("PersonalFinance")))
            {
                User newUser = new User { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, Password = password };

                string insertUser = @"INSERT INTO dbo.tblUsers(FirstName,LastName,EmailAddress,Password) Values('" + firstName + "','" + lastName + "', '" + emailAddress + "', '" + password + "')";

                var newuser = connection.Execute(insertUser, "PersonalFinance");

            }
        }

    }
}
