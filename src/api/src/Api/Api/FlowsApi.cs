﻿/*
 * FlowsApi.cs
 *
 *   Created: 2022-11-27-04:23:24
 *   Modified: 2022-12-19-11:02:38
 *
 *   This code allows access to the SendPulse Telegram chatbot API
 *
 *   Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 *   Author:  <justin@Dgmjr.com>
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

namespace SendPulse.Api;
using Abstractions;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public partial class FlowsApi : IFlowsApi
{
    private SendPulse.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public FlowsApi(string basePath)
    {
        this.Configuration = new SendPulse.Api.Client.Configuration { BasePath = basePath };

        ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowsApi"/> class
    /// </summary>
    /// <returns></returns>
    public FlowsApi()
    {
        this.Configuration = SendPulse.Api.Client.Configuration.Default;

        ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public FlowsApi(SendPulse.Api.Client.Abstractions.IConfiguration configuration = null)
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
        return this.Configuration.ApiClient.RestClient.Options!.BaseUrl.ToString();
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
        return new ReadOnlyStringDictionary(this.Configuration.DefaultHeader);
    }

    /// <summary>
    /// Add default header.
    /// </summary>
    /// <param name="key">Header field name.</param>
    /// <param name="value">Header field value.</param>
    /// <returns></returns>
    [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
    public void AddDefaultHeader(string key, string value)
    {
        this.Configuration.AddDefaultHeader(key, value);
    }

    /// <summary>
    /// Get a list of flows Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2003</returns>
    public GetFlowsByBotResponse GetFlowsByBot(string botId)
    {
        ApiResponse<GetFlowsByBotResponse> localVarResponse = FlowsGetWithHttpInfo(botId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of flows Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2003</returns>
    public ApiResponse<GetFlowsByBotResponse> FlowsGetWithHttpInfo(string botId)
    {
        // verify the required parameter 'botId' is set
        if (botId == null)
            throw new ApiException(
                400,
                "Missing required parameter 'botId' when calling FlowsApi->FlowsGet"
            );

        var localVarPath = "/flows";
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

        if (botId != null)
            localVarQueryParams.AddRange(
                this.Configuration.ApiClient.ParameterToKeyValuePairs("", "bot_id", botId)
            ); // query parameter
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
            Exception exception = ExceptionFactory("FlowsGet", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<GetFlowsByBotResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (GetFlowsByBotResponse)
                this.Configuration.ApiClient.Deserialize(
                    localVarResponse,
                    typeof(GetFlowsByBotResponse)
                )
        );
    }

    /// <summary>
    /// Get a list of flows Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2003</returns>
    public async System.Threading.Tasks.Task<GetFlowsByBotResponse> FlowsGetAsync(string botId)
    {
        ApiResponse<GetFlowsByBotResponse> localVarResponse = await FlowsGetAsyncWithHttpInfo(
            botId
        );
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of flows Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
    public async System.Threading.Tasks.Task<
        ApiResponse<GetFlowsByBotResponse>
    > FlowsGetAsyncWithHttpInfo(string botId)
    {
        // verify the required parameter 'botId' is set
        if (botId == null)
            throw new ApiException(
                400,
                "Missing required parameter 'botId' when calling FlowsApi->FlowsGet"
            );

        var localVarPath = "/flows";
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

        if (botId != null)
            localVarQueryParams.AddRange(
                this.Configuration.ApiClient.ParameterToKeyValuePairs("", "bot_id", botId)
            ); // query parameter
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
            Exception exception = ExceptionFactory("FlowsGet", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<GetFlowsByBotResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (GetFlowsByBotResponse)
                this.Configuration.ApiClient.Deserialize(
                    localVarResponse,
                    typeof(GetFlowsByBotResponse)
                )
        );
    }

    /// <summary>
    /// Run a flow by trigger keywords Launches a flow with the trigger keyword for the selected contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    public SuccessResponse FlowsRunByTriggerPost(FlowsRunByTriggerBody body)
    {
        ApiResponse<SuccessResponse> localVarResponse = FlowsRunByTriggerPostWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Run a flow by trigger keywords Launches a flow with the trigger keyword for the selected contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    public ApiResponse<SuccessResponse> FlowsRunByTriggerPostWithHttpInfo(
        FlowsRunByTriggerBody body
    )
    {
        // verify the required parameter 'body' is set
        if (body == null)
            throw new ApiException(
                400,
                "Missing required parameter 'body' when calling FlowsApi->FlowsRunByTriggerPost"
            );

        var localVarPath = "/flows/runByTrigger";
        var localVarPathParams = new StringDictionary();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new StringDictionary(this.Configuration.DefaultHeader);
        var localVarFormParams = new StringDictionary();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] { "application/json" };
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

        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }
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
                Method.Post,
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
            Exception exception = ExceptionFactory("FlowsRunByTriggerPost", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<SuccessResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (SuccessResponse)
                this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse))
        );
    }

    /// <summary>
    /// Run a flow by trigger keywords Launches a flow with the trigger keyword for the selected contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    public async System.Threading.Tasks.Task<SuccessResponse> FlowsRunByTriggerPostAsync(
        FlowsRunByTriggerBody body
    )
    {
        ApiResponse<SuccessResponse> localVarResponse =
            await FlowsRunByTriggerPostAsyncWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Run a flow by trigger keywords Launches a flow with the trigger keyword for the selected contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    public async System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > FlowsRunByTriggerPostAsyncWithHttpInfo(FlowsRunByTriggerBody body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
            throw new ApiException(
                400,
                "Missing required parameter 'body' when calling FlowsApi->FlowsRunByTriggerPost"
            );

        var localVarPath = "/flows/runByTrigger";
        var localVarPathParams = new StringDictionary();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new StringDictionary(this.Configuration.DefaultHeader);
        var localVarFormParams = new StringDictionary();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] { "application/json" };
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

        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }
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
                Method.Post,
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
            Exception exception = ExceptionFactory("FlowsRunByTriggerPost", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<SuccessResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (SuccessResponse)
                this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse))
        );
    }

    /// <summary>
    /// Run a flow by its ID Launches the selected flow for the selected contact.
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    public SuccessResponse FlowsRunPost(FlowsRunBody body)
    {
        ApiResponse<SuccessResponse> localVarResponse = FlowsRunPostWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Run a flow by its ID Launches the selected flow for the selected contact.
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    public ApiResponse<SuccessResponse> FlowsRunPostWithHttpInfo(FlowsRunBody body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
            throw new ApiException(
                400,
                "Missing required parameter 'body' when calling FlowsApi->FlowsRunPost"
            );

        var localVarPath = "/flows/run";
        var localVarPathParams = new StringDictionary();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new StringDictionary(this.Configuration.DefaultHeader);
        var localVarFormParams = new StringDictionary();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] { "application/json" };
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

        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }
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
                Method.Post,
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
            Exception exception = ExceptionFactory("FlowsRunPost", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<SuccessResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (SuccessResponse)
                this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse))
        );
    }

    /// <summary>
    /// Run a flow by its ID Launches the selected flow for the selected contact.
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    public async System.Threading.Tasks.Task<SuccessResponse> FlowsRunPostAsync(FlowsRunBody body)
    {
        ApiResponse<SuccessResponse> localVarResponse = await FlowsRunPostAsyncWithHttpInfo(body);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Run a flow by its ID Launches the selected flow for the selected contact.
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    public async System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > FlowsRunPostAsyncWithHttpInfo(FlowsRunBody body)
    {
        // verify the required parameter 'body' is set
        if (body == null)
            throw new ApiException(
                400,
                "Missing required parameter 'body' when calling FlowsApi->FlowsRunPost"
            );

        var localVarPath = "/flows/run";
        var localVarPathParams = new StringDictionary();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new StringDictionary(this.Configuration.DefaultHeader);
        var localVarFormParams = new StringDictionary();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody = null;

        // to determine the Content-Type header
        string[] localVarHttpContentTypes = new string[] { "application/json" };
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

        if (body != null && body.GetType() != typeof(byte[]))
        {
            localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
        }
        else
        {
            localVarPostBody = body; // byte array
        }
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
                Method.Post,
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
            Exception exception = ExceptionFactory("FlowsRunPost", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<SuccessResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (SuccessResponse)
                this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse))
        );
    }
}
