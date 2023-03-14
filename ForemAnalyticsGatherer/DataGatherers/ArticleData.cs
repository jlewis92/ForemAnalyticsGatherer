using ForemAnalyticsGatherer.DataGatherers.Interfaces;
using ForemAnalyticsGatherer.Settings;
using ForemAnalyticsGatherer.Utilities;

namespace ForemAnalyticsGatherer.DataGatherers
{
    public class ArticleData : IArticleData
    {
        AppSettings _settings;
        ForemVersionOne.Client.Configuration _versionOneConfig;
        ForemVersionOne.Client.ApiClient _foremVersionOneApiClient;
        ForemOpenSearch _openSearch;

        public ArticleData(AppSettings settings)
        {
            ArgumentNullException.ThrowIfNull(settings.ApiKey);
            ArgumentNullException.ThrowIfNull(settings.BasePath);
            ArgumentNullException.ThrowIfNull(settings.NodeList);

            _settings = settings;

            _versionOneConfig = new ForemVersionOne.Client.Configuration();

            _versionOneConfig.ApiKey.Add("api-key", settings.ApiKey);
            _foremVersionOneApiClient = new ForemVersionOne.Client.ApiClient(_settings.BasePath);
            _foremVersionOneApiClient.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            _openSearch = new ForemOpenSearch(_settings.NodeList);
        }

        public async Task<List<ForemVersionOne.Model.ArticleIndex>> GatherData()
        {         
            var articlesApi = new ForemVersionOne.Api.ArticlesApi(_foremVersionOneApiClient, _foremVersionOneApiClient, _versionOneConfig);

            var moreData = true;
            var articlesPerPage = 30;
            var articles = new List<ForemVersionOne.Model.ArticleIndex>();
            var currentPage = 1;

            while (moreData)
            {
                var articlesApiResponse = await articlesApi.GetUserAllArticlesWithHttpInfoAsync(page: currentPage, perPage: articlesPerPage);

                if (HttpUtilities.IsSuccessStatusCode(articlesApiResponse.StatusCode))
                {
                    articles.AddRange(articlesApiResponse.Data);
                }

                if (articlesApiResponse.Data.Count < articlesPerPage)
                {
                    moreData = false;
                }
                else
                {
                    currentPage++;
                }
            }

            await _openSearch.IndexArticleData(articles);

            return articles;
        }
    }
}
