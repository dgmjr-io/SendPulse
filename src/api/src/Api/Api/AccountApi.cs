/*
 * AccountApi.cs
 *
 *   Created: 2022-11-27-04:23:24
 *   Modified: 2022-12-19-10:55:15
 *
 *   Author:  <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 , All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace SendPulse.Api
{
    using Abstractions;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountApi : IAccountApi
    {
        private SendPulse.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountApi(string basePath)
        {
            this.Configuration = new SendPulse.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class
        /// </summary>
        /// <returns></returns>
        public AccountApi()
        {
            this.Configuration = SendPulse.Api.Client.Configuration.Default;

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountApi(SendPulse.Api.Client.Abstractions.IConfiguration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SendPulse.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options?.BaseUrl?.ToString()!;
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete(
            "SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead."
        )]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SendPulse.Api.Client.Abstractions.IConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SendPulse.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException(
                        "Multicast delegate for ExceptionFactory is unsupported."
                    );
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IStringDictionary DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete(
            "AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead."
        )]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get account info Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse20011</returns>
        public AccountInfo AccountGet()
        {
            ApiResponse<AccountInfo> localVarResponse = AccountGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account info Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        public ApiResponse<AccountInfo> AccountGetWithHttpInfo()
        {
            var localVarPath = "/account";
            var localVarPathParams = new StringDictionary();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new StringDictionary(this.Configuration.DefaultHeader);
            var localVarFormParams = new StringDictionary();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] { };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(
                localVarHttpContentTypes
            );

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] { "application/json" };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(
                localVarHttpHeaderAccepts
            );
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)
                this.Configuration.ApiClient.CallApi(
                    localVarPath,
                    Method.Get,
                    localVarQueryParams,
                    localVarPostBody,
                    localVarHeaderParams,
                    localVarFormParams,
                    localVarFileParams,
                    localVarPathParams,
                    localVarHttpContentType
                );

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountGet", localVarResponse);
                if (exception != null)
                    throw exception;
            }

            return new ApiResponse<AccountInfo>(
                localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AccountInfo)
                    this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountInfo))
            );
        }

        /// <summary>
        /// Get account info Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse20011</returns>
        public async System.Threading.Tasks.Task<AccountInfo> AccountGetAsync()
        {
            ApiResponse<AccountInfo> localVarResponse = await AccountGetAsyncWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account info Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        public async System.Threading.Tasks.Task<
            ApiResponse<AccountInfo>
        > AccountGetAsyncWithHttpInfo()
        {
            var localVarPath = "/account";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(
                this.Configuration.DefaultHeader
            );
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] { };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(
                localVarHttpContentTypes
            );

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] { "application/json" };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(
                localVarHttpHeaderAccepts
            );
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)
                await this.Configuration.ApiClient.CallApiAsync(
                    localVarPath,
                    Method.Get,
                    localVarQueryParams,
                    localVarPostBody,
                    localVarHeaderParams,
                    localVarFormParams,
                    localVarFileParams,
                    localVarPathParams,
                    localVarHttpContentType
                );

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountGet", localVarResponse);
                if (exception != null)
                    throw exception;
            }

            return new ApiResponse<AccountInfo>(
                localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AccountInfo)
                    this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountInfo))
            );
        }
    }
}
