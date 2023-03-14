using ForemAnalyticsGatherer.DataGatherers.Interfaces;
using ForemAnalyticsGatherer.Settings;
using ForemAnalyticsGatherer.Utilities;

namespace ForemAnalyticsGatherer.DataGatherers
{
    public class FollowerData : IFollowerData
    {
        ForemVersionZero.Client.Configuration _versionZeroConfig;
        ForemVersionZero.Client.ApiClient _foremVersionZeroApiClient;
        ForemOpenSearch _openSearch;
        AppSettings _settings;

        public FollowerData(AppSettings settings)
        {
            ArgumentNullException.ThrowIfNull(settings.ApiKey);
            ArgumentNullException.ThrowIfNull(settings.BasePath);
            ArgumentNullException.ThrowIfNull(settings.NodeList);

            _settings = settings;

            _versionZeroConfig = new ForemVersionZero.Client.Configuration();

            _versionZeroConfig.ApiKey.Add("api-key", settings.ApiKey);
            _foremVersionZeroApiClient = new ForemVersionZero.Client.ApiClient(_settings.BasePath + "/api");
            _foremVersionZeroApiClient.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            _openSearch = new ForemOpenSearch(_settings.NodeList);
        }

        public async Task<List<ForemVersionZero.Model.Follower>> GatherData()
        {
            var followersApi = new ForemVersionZero.Api.FollowersApi(_foremVersionZeroApiClient, _foremVersionZeroApiClient, _versionZeroConfig);

            var moreData = true;
            var followersPerPage = 80;
            var followers = new List<ForemVersionZero.Model.Follower>();
            var currentPage = 1;

            while (moreData)
            {
                var followersApiResponse = await followersApi.GetFollowersWithHttpInfoAsync(page: currentPage, perPage: followersPerPage, sort: "created_at");

                if (HttpUtilities.IsSuccessStatusCode(followersApiResponse.StatusCode))
                {
                    followers.AddRange(followersApiResponse.Data);
                }

                if (followersApiResponse.Data.Count < followersPerPage)
                {
                    moreData = false;
                }
                else
                {
                    currentPage++;
                }
            }

            await _openSearch.IndexFollowerData(followers);

            return followers;
        }
    }
}
