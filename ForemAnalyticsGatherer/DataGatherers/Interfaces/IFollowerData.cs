namespace ForemAnalyticsGatherer.DataGatherers.Interfaces
{
    public interface IFollowerData
    {
        Task<List<ForemVersionZero.Model.Follower>> GatherData();
    }
}
