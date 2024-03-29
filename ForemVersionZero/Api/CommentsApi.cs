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
    public interface ICommentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Comment</returns>
        Comment GetCommentById(string id, int operationIndex = 0);

        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Comment</returns>
        ApiResponse<Comment> GetCommentByIdWithHttpInfo(string id, int operationIndex = 0);
        /// <summary>
        /// Comments
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Comment&gt;</returns>
        List<Comment> GetCommentsByArticleId(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0);

        /// <summary>
        /// Comments
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Comment&gt;</returns>
        ApiResponse<List<Comment>> GetCommentsByArticleIdWithHttpInfo(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Comment</returns>
        System.Threading.Tasks.Task<Comment> GetCommentByIdAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Comment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Comment>> GetCommentByIdWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Comments
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Comment&gt;</returns>
        System.Threading.Tasks.Task<List<Comment>> GetCommentsByArticleIdAsync(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Comments
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </remarks>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Comment&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Comment>>> GetCommentsByArticleIdWithHttpInfoAsync(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICommentsApi : ICommentsApiSync, ICommentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CommentsApi : ICommentsApi
    {
        private ForemVersionZero.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommentsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="CommentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CommentsApi(ForemVersionZero.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CommentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CommentsApi(ForemVersionZero.Client.ISynchronousClient client, ForemVersionZero.Client.IAsynchronousClient asyncClient, ForemVersionZero.Client.IReadableConfiguration configuration)
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
        /// Comment This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Comment</returns>
        public Comment GetCommentById(string id, int operationIndex = 0)
        {
            ForemVersionZero.Client.ApiResponse<Comment> localVarResponse = GetCommentByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Comment This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Comment</returns>
        public ForemVersionZero.Client.ApiResponse<Comment> GetCommentByIdWithHttpInfo(string id, int operationIndex = 0)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ForemVersionZero.Client.ApiException(400, "Missing required parameter 'id' when calling CommentsApi->GetCommentById");
            }

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

            localVarRequestOptions.PathParameters.Add("id", ForemVersionZero.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "CommentsApi.GetCommentById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<Comment>("/comments/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCommentById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Comment This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Comment</returns>
        public async System.Threading.Tasks.Task<Comment> GetCommentByIdAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ForemVersionZero.Client.ApiResponse<Comment> localVarResponse = await GetCommentByIdWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Comment This endpoint allows the client to retrieve a comment as well as his descendants comments.  It will return the required comment (the root) with its nested descendants as a thread.  See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Comment identifier.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Comment)</returns>
        public async System.Threading.Tasks.Task<ForemVersionZero.Client.ApiResponse<Comment>> GetCommentByIdWithHttpInfoAsync(string id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ForemVersionZero.Client.ApiException(400, "Missing required parameter 'id' when calling CommentsApi->GetCommentById");
            }


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

            localVarRequestOptions.PathParameters.Add("id", ForemVersionZero.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "CommentsApi.GetCommentById";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<Comment>("/comments/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCommentById", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Comments This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Comment&gt;</returns>
        public List<Comment> GetCommentsByArticleId(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0)
        {
            ForemVersionZero.Client.ApiResponse<List<Comment>> localVarResponse = GetCommentsByArticleIdWithHttpInfo(aId, pId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Comments This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Comment&gt;</returns>
        public ForemVersionZero.Client.ApiResponse<List<Comment>> GetCommentsByArticleIdWithHttpInfo(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0)
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

            if (aId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "a_id", aId));
            }
            if (pId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "p_id", pId));
            }

            localVarRequestOptions.Operation = "CommentsApi.GetCommentsByArticleId";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Comment>>("/comments", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCommentsByArticleId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Comments This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Comment&gt;</returns>
        public async System.Threading.Tasks.Task<List<Comment>> GetCommentsByArticleIdAsync(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ForemVersionZero.Client.ApiResponse<List<Comment>> localVarResponse = await GetCommentsByArticleIdWithHttpInfoAsync(aId, pId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Comments This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.  It will return the all top level comments with their nested comments as threads. See the format specification for further details. 
        /// </summary>
        /// <exception cref="ForemVersionZero.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aId">Article identifier. (optional)</param>
        /// <param name="pId">Podcast Episode identifier. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Comment&gt;)</returns>
        public async System.Threading.Tasks.Task<ForemVersionZero.Client.ApiResponse<List<Comment>>> GetCommentsByArticleIdWithHttpInfoAsync(int? aId = default(int?), int? pId = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (aId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "a_id", aId));
            }
            if (pId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ForemVersionZero.Client.ClientUtils.ParameterToMultiMap("", "p_id", pId));
            }

            localVarRequestOptions.Operation = "CommentsApi.GetCommentsByArticleId";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Comment>>("/comments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCommentsByArticleId", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
