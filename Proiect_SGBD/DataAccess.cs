using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_SGBD
{
    class DataAccess
    {
        private string database = "sqltutorial";

        internal Account InsertData(string username, string password, string firstName, string lastName, string emailAddress)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal(database)))
            {
                bool exist = false;
                Account newAccount = new Account
                {
                    Username = username,
                    Password = password,
                    FirstName = firstName,
                    LastName = lastName,
                    EmailAddress = emailAddress
                };

                var accounts = connection.Query<Account>("spAccounts_GetAuthenticationInformation @Username, @Password", 
                                                                    new { Username = username, Password = password }).ToList();

                if (AuthenticationVerify(accounts, username, password))
                    {
                        MessageBox.Show("Account already exist !!!");
                        exist = true;
                    }
                
                if(exist == false)
                {
                    connection.Execute("spAccounts_InsertNewAccount @Username, @Password, @FirstName, @LastName, @EmailAddress", newAccount);

                    return newAccount;
                }

                return null;
            }
        }

        internal void rentACar(string row)
        {
            throw new NotImplementedException();
        }

        internal List<Car> ShowUnoccupiedCars()
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal(database)))
            {
                List<Car> cars;

                cars = connection.Query<Car>("Select *from dbo.SelectUnoccupedCars()").ToList();

                if (cars.Count != 0)
                    return cars;
            }

            return null;
        }

        internal void updateInfromation(int index, string columnValue, string row)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal(database)))
            {
                connection.Execute("dbo.spCars_Update @Index, @ColumnValue, @Row", new { Index = index, ColumnValue = columnValue, Row = row }) ;
            }
        }

        internal void deleteRow(string rowForDeleting)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal(database)))
            {
                connection.Execute("dbo.spCars_DeleteRow @id", new { id = rowForDeleting });
            }
        }

        internal List<Car> GetTheListOfCars()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal(database)))
            {
                List<Car> cars = new List<Car>();
                cars = connection.Query<Car>("select *from dbo.SelectAllCars();").ToList();
                return cars;
            }
        }

        public Account GetUserInformation(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal(database)))
            {
                var output = connection.Query<Account>("dbo.spAccounts_GetUserInformation @Username, @Password", new { Username = username, Password = password }).ToList();

                foreach (Account account in output)
                    return account;
                
            }

           return null;
        }

        internal bool ExistAccount(string username, string password)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionVal(database)))
            {
                var accounts = connection.Query<Account>("spAccounts_GetAuthenticationInformation @Username, @Password", 
                                                                    new { Username = username, Password = password }).ToList();

                if (AuthenticationVerify(accounts, username, password))
                    return true;

                return false;
            }
        }

        private bool AuthenticationVerify(List<Account> accounts, string username, string password)
        {
            foreach (Account account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
