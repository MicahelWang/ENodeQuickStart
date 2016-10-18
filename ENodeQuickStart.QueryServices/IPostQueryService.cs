using ENodeQuickStart.QueryServices.Dtos;

namespace ENodeQuickStart.QueryServices
{
    public interface IPostQueryService
    {
        /// <summary>Find posts by page.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        PostQueryResult Find(PostQueryOption option);
        /// <summary>Find a single post.
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        MessageInfo Find(string postId);
        /// <summary>Find a single post, returns the dynamic data.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        dynamic FindDynamic(string id, string option);
    }
}