using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommon.Components;
using ECommon.Dapper;
using ENodeQuickStart.Domain.Accounts;
using ENodeQuickStart.Infrastructure;

namespace ENodeQuickStart.Domain.Dapper
{
    [Component]
    public class AccountIndexRepository : IAccountIndexRepository
    {
        public AccountIndex FindByAccountName(string accountName)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var data =
                    connection.QueryList(new {AccountName = accountName}, Constants.AccountIndexTable).SingleOrDefault();
                if (data!=null)
                {
                    return new AccountIndex(data.AccountId as string,accountName);
                }
                return null;

            }
        }

        public void Add(AccountIndex index)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                connection.Insert(new
                {
                    AccountId = index.AccountId,
                    AccountName = index.AccountName
                }, Constants.AccountIndexTable);
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigSettings.ForumConnectionString);
        }
    }
}