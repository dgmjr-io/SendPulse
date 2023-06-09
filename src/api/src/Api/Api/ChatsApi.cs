﻿/*
 * ChatsApi.cs
 *
 *   Created: 2022-11-27-04:23:24
 *   Modified: 2022-12-19-11:02:23
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
public partial class ChatsApi : IChatsApi
{
    private SendPulse.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ChatsApi(string basePath)
    {
        this.Configuration = new SendPulse.Api.Client.Configuration { BasePath = basePath };

        ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatsApi"/> class
    /// </summary>
    /// <returns></returns>
    public ChatsApi()
    {
        this.Configuration = SendPulse.Api.Client.Configuration.Default;

        ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatsApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public ChatsApi(SendPulse.Api.Client.Abstractions.IConfiguration configuration = null)
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
        return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
    /// Get a list of chats Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2007</returns>
    public GetBotsChatsByBotIdResponse GetBotsChatsByBotId(string botId)
    {
        ApiResponse<GetBotsChatsByBotIdResponse> localVarResponse = ChatsGetWithHttpInfo(botId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of chats Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2007</returns>
    public ApiResponse<GetBotsChatsByBotIdResponse> ChatsGetWithHttpInfo(string botId)
    {
        // verify the required parameter 'botId' is set
        if (botId == null)
            throw new ApiException(
                400,
                "Missing required parameter 'botId' when calling ChatsApi->ChatsGet"
            );

        var localVarPath = "/chats";
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
            Exception exception = ExceptionFactory("ChatsGet", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<GetBotsChatsByBotIdResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (GetBotsChatsByBotIdResponse)
                this.Configuration.ApiClient.Deserialize(
                    localVarResponse,
                    typeof(GetBotsChatsByBotIdResponse)
                )
        );
    }

    /// <summary>
    /// Get a list of chats Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2007</returns>
    public async System.Threading.Tasks.Task<GetBotsChatsByBotIdResponse> ChatsGetAsync(
        string botId
    )
    {
        ApiResponse<GetBotsChatsByBotIdResponse> localVarResponse = await ChatsGetAsyncWithHttpInfo(
            botId
        );
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of chats Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
    public async System.Threading.Tasks.Task<
        ApiResponse<GetBotsChatsByBotIdResponse>
    > ChatsGetAsyncWithHttpInfo(string botId)
    {
        // verify the required parameter 'botId' is set
        if (botId == null)
            throw new ApiException(
                400,
                "Missing required parameter 'botId' when calling ChatsApi->ChatsGet"
            );

        var localVarPath = "/chats";
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
            Exception exception = ExceptionFactory("ChatsGet", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<GetBotsChatsByBotIdResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (GetBotsChatsByBotIdResponse)
                this.Configuration.ApiClient.Deserialize(
                    localVarResponse,
                    typeof(GetBotsChatsByBotIdResponse)
                )
        );
    }

    /// <summary>
    /// Get a list of messages Returns a list of all messages in correspondence with the specified subscriber
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2008</returns>
    public PagedMessagesResponse ChatsMessagesGet(string contactId)
    {
        ApiResponse<PagedMessagesResponse> localVarResponse = ChatsMessagesGetWithHttpInfo(
            contactId
        );
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of messages Returns a list of all messages in correspondence with the specified subscriber
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2008</returns>
    public ApiResponse<PagedMessagesResponse> ChatsMessagesGetWithHttpInfo(string contactId)
    {
        // verify the required parameter 'contactId' is set
        if (contactId == null)
            throw new ApiException(
                400,
                "Missing required parameter 'contactId' when calling ChatsApi->ChatsMessagesGet"
            );

        var localVarPath = "/chats/messages";
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

        if (contactId != null)
            localVarQueryParams.AddRange(
                this.Configuration.ApiClient.ParameterToKeyValuePairs("", "contact_id", contactId)
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
            Exception exception = ExceptionFactory("ChatsMessagesGet", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<PagedMessagesResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (PagedMessagesResponse)
                this.Configuration.ApiClient.Deserialize(
                    localVarResponse,
                    typeof(PagedMessagesResponse)
                )
        );
    }

    /// <summary>
    /// Get a list of messages Returns a list of all messages in correspondence with the specified subscriber
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2008</returns>
    public async System.Threading.Tasks.Task<PagedMessagesResponse> ChatsMessagesGetAsync(
        string contactId
    )
    {
        ApiResponse<PagedMessagesResponse> localVarResponse =
            await ChatsMessagesGetAsyncWithHttpInfo(contactId);
        return localVarResponse.Data;
    }

    /// <summary>
    /// Get a list of messages Returns a list of all messages in correspondence with the specified subscriber
    /// </summary>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
    public async System.Threading.Tasks.Task<
        ApiResponse<PagedMessagesResponse>
    > ChatsMessagesGetAsyncWithHttpInfo(string contactId)
    {
        // verify the required parameter 'contactId' is set
        if (contactId == null)
            throw new ApiException(
                400,
                "Missing required parameter 'contactId' when calling ChatsApi->ChatsMessagesGet"
            );

        var localVarPath = "/chats/messages";
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

        if (contactId != null)
            localVarQueryParams.AddRange(
                this.Configuration.ApiClient.ParameterToKeyValuePairs("", "contact_id", contactId)
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
            Exception exception = ExceptionFactory("ChatsMessagesGet", localVarResponse);
            if (exception != null)
                throw exception;
        }

        return new ApiResponse<PagedMessagesResponse>(
            localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (PagedMessagesResponse)
                this.Configuration.ApiClient.Deserialize(
                    localVarResponse,
                    typeof(PagedMessagesResponse)
                )
        );
    }
}
