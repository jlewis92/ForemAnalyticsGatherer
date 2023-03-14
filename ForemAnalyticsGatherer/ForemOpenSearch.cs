using OpenSearch.Client;
using OpenSearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForemAnalyticsGatherer
{
    public class ForemOpenSearch
    {
        OpenSearchClient _openSearchClient;

        public ForemOpenSearch(List<Uri> nodes)
        {
            var pool = new StaticConnectionPool(nodes);
            var settings = new ConnectionSettings(pool);
            _openSearchClient = new OpenSearchClient(settings);
        }

        /// <summary>
        /// Indexes articles into OpenSearch
        /// </summary>
        /// <param name="articles">The articles to index</param>
        /// <returns>A response based on whether the upload succeeded</returns>
        public async Task<BulkResponse> IndexArticleData(List<ForemVersionOne.Model.ArticleIndex> articles)
        {
            var response = await _openSearchClient.IndexManyAsync(articles, "articles");

            return response;
        }

        /// <summary>
        /// Index followers into OpenSearch
        /// </summary>
        /// <param name="followers">A list of followers to index</param>
        /// <returns>A response based on whether the upload succeeded</returns>
        public async Task<BulkResponse> IndexFollowerData(List<ForemVersionZero.Model.Follower> followers)
        {
            var response = await _openSearchClient.IndexManyAsync(followers, "followers");

            return response;
        }
    }
}
