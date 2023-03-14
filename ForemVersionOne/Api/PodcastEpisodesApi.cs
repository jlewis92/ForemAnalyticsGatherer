/*
 * Forem API V1
 *
 * Access Forem articles, users and other resources via API.         For a real-world example of Forem in action, check out [DEV](https://www.dev.to).         All endpoints can be accessed with the 'api-key' header and a accept header, but         some of them are accessible publicly without authentication.          Dates and date times, unless otherwise specified, must be in         the [RFC 3339](https://tools.ietf.org/html/rfc3339) format.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ForemVersionOne.Client;
using ForemVersionOne.Model;

namespace ForemVersionOne.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPodcastEpisodesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Podcast Episodes
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PodcastEpisodeIndex&gt;</returns>
        List<PodcastEpisodeIndex> GetPodcastEpisodes(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0);

        /// <summary>
        /// Podcast Episodes
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PodcastEpisodeIndex&gt;</returns>
        ApiResponse<List<PodcastEpisodeIndex>> GetPodcastEpisodesWithHttpInfo(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPodcastEpisodesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Podcast Episodes
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PodcastEpisodeIndex&gt;</returns>
        System.Threading.Tasks.Task<List<PodcastEpisodeIndex>> GetPodcastEpisodesAsync(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Podcast Episodes
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PodcastEpisodeIndex&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PodcastEpisodeIndex>>> GetPodcastEpisodesWithHttpInfoAsync(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPodcastEpisodesApi : IPodcastEpisodesApiSync, IPodcastEpisodesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PodcastEpisodesApi : IPodcastEpisodesApi
    {
        private ForemVersionOne.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisodesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PodcastEpisodesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisodesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PodcastEpisodesApi(string basePath)
        {
            this.Configuration = ForemVersionOne.Client.Configuration.MergeConfigurations(
                ForemVersionOne.Client.GlobalConfiguration.Instance,
                new ForemVersionOne.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ForemVersionOne.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ForemVersionOne.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ForemVersionOne.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisodesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PodcastEpisodesApi(ForemVersionOne.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ForemVersionOne.Client.Configuration.MergeConfigurations(
                ForemVersionOne.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ForemVersionOne.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ForemVersionOne.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ForemVersionOne.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastEpisodesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PodcastEpisodesApi(ForemVersionOne.Client.ISynchronousClient client, ForemVersionOne.Client.IAsynchronousClient asyncClient, ForemVersionOne.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ForemVersionOne.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ForemVersionOne.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ForemVersionOne.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ForemVersionOne.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ForemVersionOne.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Podcast Episodes This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;PodcastEpisodeIndex&gt;</returns>
        public List<PodcastEpisodeIndex> GetPodcastEpisodes(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0)
        {
            ForemVersionOne.Client.ApiResponse<List<PodcastEpisodeIndex>> localVarResponse = GetPodcastEpisodesWithHttpInfo(page, perPage, username);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Podcast Episodes This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;PodcastEpisodeIndex&gt;</returns>
        public ForemVersionOne.Client.ApiResponse<List<PodcastEpisodeIndex>> GetPodcastEpisodesWithHttpInfo(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0)
        {
            ForemVersionOne.Client.RequestOptions localVarRequestOptions = new ForemVersionOne.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ForemVersionOne.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ForemVersionOne.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionOne.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionOne.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }
            if (username != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionOne.Client.ClientUtils.ParameterToMultiMap("", "username", username));
            }

            localVarRequestOptions.Operation = "PodcastEpisodesApi.GetPodcastEpisodes";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<PodcastEpisodeIndex>>("/api/podcast_episodes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPodcastEpisodes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Podcast Episodes This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PodcastEpisodeIndex&gt;</returns>
        public async System.Threading.Tasks.Task<List<PodcastEpisodeIndex>> GetPodcastEpisodesAsync(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ForemVersionOne.Client.ApiResponse<List<PodcastEpisodeIndex>> localVarResponse = await GetPodcastEpisodesWithHttpInfoAsync(page, perPage, username, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Podcast Episodes This endpoint allows the client to retrieve a list of podcast episodes.         \&quot;Podcast episodes\&quot; are episodes belonging to podcasts.         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.         It supports pagination, each page will contain 30 articles by default.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). The default maximum value can be overridden by \&quot;API_PER_PAGE_MAX\&quot; environment variable. (optional, default to 30)</param>
        /// <param name="username">Using this parameter will retrieve episodes belonging to a specific podcast. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PodcastEpisodeIndex&gt;)</returns>
        public async System.Threading.Tasks.Task<ForemVersionOne.Client.ApiResponse<List<PodcastEpisodeIndex>>> GetPodcastEpisodesWithHttpInfoAsync(int? page = default(int?), int? perPage = default(int?), string? username = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ForemVersionOne.Client.RequestOptions localVarRequestOptions = new ForemVersionOne.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ForemVersionOne.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ForemVersionOne.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionOne.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionOne.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }
            if (username != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionOne.Client.ClientUtils.ParameterToMultiMap("", "username", username));
            }

            localVarRequestOptions.Operation = "PodcastEpisodesApi.GetPodcastEpisodes";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PodcastEpisodeIndex>>("/api/podcast_episodes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPodcastEpisodes", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}