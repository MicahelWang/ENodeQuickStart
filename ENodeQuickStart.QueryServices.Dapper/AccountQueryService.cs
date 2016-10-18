using System.Collections.Generic;
using System.Linq;
using ECommon.Components;
using ECommon.Dapper;
using ENodeQuickStart.Infrastructure;
using ENodeQuickStart.QueryServices.Dtos;

namespace ENodeQuickStart.QueryServices.Dapper
{
    [Component]
    public class AccountQueryService : BaseQueryService, IAccountQueryService
    {
        public AccountInfo Find(string name)
        {
            using (var connection = GetConnection())
            {
                return connection.QueryList<AccountInfo>(new { Name = name }, Constants.AccountTable).SingleOrDefault();
            }
        }

        public IEnumerable<AccountAndStatistic> FindAllInculdeStatistic()
        {
            throw new System.NotImplementedException();
        }

        public dynamic FindDynamic(string id, string option)
        {
            throw new System.NotImplementedException();
        }

        public AccountAndStatistic FindInculdeStatisticById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}