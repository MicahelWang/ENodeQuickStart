namespace ENodeQuickStart.QueryServices.Dtos
{
    public class AccountAndStatistic : AccountInfo{
        public int MessageCount { get; set; }
        public int ReplyCount { get; set; }
    }
}
