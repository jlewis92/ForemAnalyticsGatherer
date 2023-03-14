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
    public interface IFollowsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Followed tags
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;FollowedTag&gt;</returns>
        List<FollowedTag> GetFollowedTags(int operationIndex = 0);

        /// <summary>
        /// Followed tags
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;FollowedTag&gt;</returns>
        ApiResponse<List<FollowedTag>> GetFollowedTagsWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFollowsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Followed tags
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;FollowedTag&gt;</returns>
        System.Threading.Tasks.Task<List<FollowedTag>> GetFollowedTagsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Followed tags
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;FollowedTag&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FollowedTag>>> GetFollowedTagsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFollowsApi : IFollowsApiSync, IFollowsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FollowsApi : IFollowsApi
    {
        private ForemVersionZero.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FollowsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FollowsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FollowsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FollowsApi(ForemVersionZero.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FollowsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public FollowsApi(ForemVersionZero.Client.ISynchronousClient client, ForemVersionZero.Client.IAsynchronousClient asyncClient, ForemVersionZero.Client.IReadableConfiguration configuration)
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
        /// Followed tags This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;FollowedTag&gt;</returns>
        public List<FollowedTag> GetFollowedTags(int operationIndex = 0)
        {
            ForemVersionZero.Client.ApiResponse<List<FollowedTag>> localVarResponse = GetFollowedTagsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Followed tags This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;FollowedTag&gt;</returns>
        public ForemVersionZero.Client.ApiResponse<List<FollowedTag>> GetFollowedTagsWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "FollowsApi.GetFollowedTags";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api-key", this.Configuration.GetApiKeyWithPrefix("api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<FollowedTag>>("/follows/tags", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFollowedTags", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Followed tags This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;FollowedTag&gt;</returns>
        public async System.Threading.Tasks.Task<List<FollowedTag>> GetFollowedTagsAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ForemVersionZero.Client.ApiResponse<List<FollowedTag>> localVarResponse = await GetFollowedTagsWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Followed tags This endpoint allows the client to retrieve a list of the tags they follow. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;FollowedTag&gt;)</returns>
        public async System.Threading.Tasks.Task<ForemVersionZero.Client.ApiResponse<List<FollowedTag>>> GetFollowedTagsWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "FollowsApi.GetFollowedTags";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api_key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api-key", this.Configuration.GetApiKeyWithPrefix("api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<FollowedTag>>("/follows/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetFollowedTags", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}