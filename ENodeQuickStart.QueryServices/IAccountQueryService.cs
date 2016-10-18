using System.Collections.Generic;
using ENodeQuickStart.QueryServices.Dtos;

namespace ENodeQuickStart.QueryServices
{
    public interface IAccountQueryService
    {
        /// <summary>Find a single account by account name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        AccountInfo Find(string name);


        IEnumerable<AccountAndStatistic> FindAllInculdeStatistic();
        /// <summary>Find a single section, returns the dynamic data.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        dynamic FindDynamic(string id, string option);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AccountAndStatistic FindInculdeStatisticById(string id);
    }
}
