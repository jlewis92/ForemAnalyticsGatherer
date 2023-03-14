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
    public interface IProfileImagesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// A Users or organizations profile image
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ProfileImage&gt;</returns>
        List<ProfileImage> GetProfileImage(string username, int operationIndex = 0);

        /// <summary>
        /// A Users or organizations profile image
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ProfileImage&gt;</returns>
        ApiResponse<List<ProfileImage>> GetProfileImageWithHttpInfo(string username, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfileImagesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// A Users or organizations profile image
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProfileImage&gt;</returns>
        System.Threading.Tasks.Task<List<ProfileImage>> GetProfileImageAsync(string username, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// A Users or organizations profile image
        /// </summary>
        /// <remarks>
        /// This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </remarks>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProfileImage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ProfileImage>>> GetProfileImageWithHttpInfoAsync(string username, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfileImagesApi : IProfileImagesApiSync, IProfileImagesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProfileImagesApi : IProfileImagesApi
    {
        private ForemVersionOne.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProfileImagesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProfileImagesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProfileImagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProfileImagesApi(ForemVersionOne.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProfileImagesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProfileImagesApi(ForemVersionOne.Client.ISynchronousClient client, ForemVersionOne.Client.IAsynchronousClient asyncClient, ForemVersionOne.Client.IReadableConfiguration configuration)
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
        /// A Users or organizations profile image This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ProfileImage&gt;</returns>
        public List<ProfileImage> GetProfileImage(string username, int operationIndex = 0)
        {
            ForemVersionOne.Client.ApiResponse<List<ProfileImage>> localVarResponse = GetProfileImageWithHttpInfo(username);
            return localVarResponse.Data;
        }

        /// <summary>
        /// A Users or organizations profile image This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ProfileImage&gt;</returns>
        public ForemVersionOne.Client.ApiResponse<List<ProfileImage>> GetProfileImageWithHttpInfo(string username, int operationIndex = 0)
        {
            // verify the required parameter 'username' is set
            if (username == null)
            {
                throw new ForemVersionOne.Client.ApiException(400, "Missing required parameter 'username' when calling ProfileImagesApi->GetProfileImage");
            }

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

            localVarRequestOptions.PathParameters.Add("username", ForemVersionOne.Client.ClientUtils.ParameterToString(username)); // path parameter

            localVarRequestOptions.Operation = "ProfileImagesApi.GetProfileImage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api-key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api-key", this.Configuration.GetApiKeyWithPrefix("api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ProfileImage>>("/api/profile_images/{username}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetProfileImage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// A Users or organizations profile image This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ProfileImage&gt;</returns>
        public async System.Threading.Tasks.Task<List<ProfileImage>> GetProfileImageAsync(string username, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ForemVersionOne.Client.ApiResponse<List<ProfileImage>> localVarResponse = await GetProfileImageWithHttpInfoAsync(username, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// A Users or organizations profile image This endpoint allows the client to retrieve a user or organization profile image information by its         corresponding username.
        /// </summary>
        /// <exception cref="ForemVersionOne.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The parameter is the username of the user or the username of the organization.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ProfileImage&gt;)</returns>
        public async System.Threading.Tasks.Task<ForemVersionOne.Client.ApiResponse<List<ProfileImage>>> GetProfileImageWithHttpInfoAsync(string username, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'username' is set
            if (username == null)
            {
                throw new ForemVersionOne.Client.ApiException(400, "Missing required parameter 'username' when calling ProfileImagesApi->GetProfileImage");
            }


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

            localVarRequestOptions.PathParameters.Add("username", ForemVersionOne.Client.ClientUtils.ParameterToString(username)); // path parameter

            localVarRequestOptions.Operation = "ProfileImagesApi.GetProfileImage";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (api-key) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api-key", this.Configuration.GetApiKeyWithPrefix("api-key"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ProfileImage>>("/api/profile_images/{username}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetProfileImage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}