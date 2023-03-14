namespace ForemAnalyticsGatherer.DataGatherers.Interfaces
{
    public interface IArticleData
    {
        Task<List<ForemVersionOne.Model.ArticleIndex>> GatherData();
    }
}
