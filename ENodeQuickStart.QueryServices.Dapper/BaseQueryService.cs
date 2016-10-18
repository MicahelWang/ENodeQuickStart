using System.Data;
using System.Data.SqlClient;
using ENodeQuickStart.Infrastructure;

namespace ENodeQuickStart.QueryServices.Dapper
{
    public abstract class BaseQueryService
    {
        protected IDbConnection GetConnection()
        {
            return new SqlConnection(ConfigSettings.ENodeQuickStartConnectionString);
        }
    }
}
