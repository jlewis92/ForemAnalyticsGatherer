/*
 * DEV API (beta)
 *
 *  Access Forem articles, users and other resources via API.  For a real-world example of Forem in action, check out [DEV](https://www.dev.to).  All endpoints that don't require authentication are CORS enabled.  All requests must send a user-agent header.  Dates and date times, unless otherwise specified, must be in the [RFC 3339](https://tools.ietf.org/html/rfc3339) format. 
 *
 * The version of the OpenAPI document: 0.9.7
 * Contact: yo@dev.to
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ForemVersionZero.Client;
using ForemVersionZero.Model;

namespace ForemVersionZero.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReadinglistApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// User&#39;s reading list
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ReadingList&gt;</returns>
        List<ReadingList> GetReadinglist(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0);

        /// <summary>
        /// User&#39;s reading list
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ReadingList&gt;</returns>
        ApiResponse<List<ReadingList>> GetReadinglistWithHttpInfo(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReadinglistApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// User&#39;s reading list
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ReadingList&gt;</returns>
        System.Threading.Tasks.Task<List<ReadingList>> GetReadinglistAsync(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// User&#39;s reading list
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ReadingList&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ReadingList>>> GetReadinglistWithHttpInfoAsync(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReadinglistApi : IReadinglistApiSync, IReadinglistApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReadinglistApi : IReadinglistApi
    {
        private ForemVersionZero.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinglistApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReadinglistApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinglistApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReadinglistApi(string basePath)
        {
            this.Configuration = ForemVersionZero.Client.Configuration.MergeConfigurations(
                ForemVersionZero.Client.GlobalConfiguration.Instance,
                new ForemVersionZero.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ForemVersionZero.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ForemVersionZero.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ForemVersionZero.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinglistApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReadinglistApi(ForemVersionZero.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ForemVersionZero.Client.Configuration.MergeConfigurations(
                ForemVersionZero.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ForemVersionZero.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ForemVersionZero.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ForemVersionZero.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinglistApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ReadinglistApi(ForemVersionZero.Client.ISynchronousClient client, ForemVersionZero.Client.IAsynchronousClient asyncClient, ForemVersionZero.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ForemVersionZero.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ForemVersionZero.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ForemVersionZero.Client.ISynchronousClient Client { get; set; }

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
        public ForemVersionZero.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ForemVersionZero.Client.ExceptionFactory ExceptionFactory
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
        /// User&#39;s reading list This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ReadingList&gt;</returns>
        public List<ReadingList> GetReadinglist(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0)
        {
            ForemVersionZero.Client.ApiResponse<List<ReadingList>> localVarResponse = GetReadinglistWithHttpInfo(page, perPage);
            return localVarResponse.Data;
        }

        /// <summary>
        /// User&#39;s reading list This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ReadingList&gt;</returns>
        public ForemVersionZero.Client.ApiResponse<List<ReadingList>> GetReadinglistWithHttpInfo(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0)
        {
            ForemVersionZero.Client.RequestOptions localVarRequestOptions = new ForemVersionZero.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ForemVersionZero.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ForemVersionZero.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }

            localVarRequestOptions.Operation = "ReadinglistApi.GetReadinglist";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api-key", this.Configuration.GetApiKeyWithPrefix("api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ReadingList>>("/readinglist", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReadinglist", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// User&#39;s reading list This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ReadingList&gt;</returns>
        public async System.Threading.Tasks.Task<List<ReadingList>> GetReadinglistAsync(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ForemVersionZero.Client.ApiResponse<List<ReadingList>> localVarResponse = await GetReadinglistWithHttpInfoAsync(page, perPage, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// User&#39;s reading list This endpoint allows the client to retrieve a list of readinglist reactions along with the related article for the authenticated user.  Reading list will be in reverse chronological order base on the creation of the reaction.  It will return paginated reading list items along with the articles they refer to. By default a page will contain &#x60;30&#x60; items 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Pagination page. (optional, default to 1)</param>
        /// <param name="perPage">Page size (the number of items to return per page). (optional, default to 30)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ReadingList&gt;)</returns>
        public async System.Threading.Tasks.Task<ForemVersionZero.Client.ApiResponse<List<ReadingList>>> GetReadinglistWithHttpInfoAsync(int? page = default(int?), int? perPage = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ForemVersionZero.Client.RequestOptions localVarRequestOptions = new ForemVersionZero.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ForemVersionZero.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ForemVersionZero.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }

            localVarRequestOptions.Operation = "ReadinglistApi.GetReadinglist";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api-key", this.Configuration.GetApiKeyWithPrefix("api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ReadingList>>("/readinglist", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetReadinglist", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
