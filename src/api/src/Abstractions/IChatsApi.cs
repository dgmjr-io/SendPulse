/*
 * IChatsApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:39:05
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using SendPulse.Api.Client;
using SendPulse.Api.Client.Abstractions;
using SendPulse.Api.Models;

namespace SendPulse.Api.Abstractions;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IChatsApi : SendPulse.Api.Client.Abstractions.IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get a list of chats
    /// </summary>
    /// <remarks>
    /// Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2007</returns>
    GetBotsChatsByBotIdResponse GetBotsChatsByBotId(string botId);

    /// <summary>
    /// Get a list of chats
    /// </summary>
    /// <remarks>
    /// Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2007</returns>
    ApiResponse<GetBotsChatsByBotIdResponse> ChatsGetWithHttpInfo(string botId);

    /// <summary>
    /// Get a list of messages
    /// </summary>
    /// <remarks>
    /// Returns a list of all messages in correspondence with the specified subscriber
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2008</returns>
    PagedMessagesResponse ChatsMessagesGet(string contactId);

    /// <summary>
    /// Get a list of messages
    /// </summary>
    /// <remarks>
    /// Returns a list of all messages in correspondence with the specified subscriber
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2008</returns>
    ApiResponse<PagedMessagesResponse> ChatsMessagesGetWithHttpInfo(string contactId);

    #endregion Synchronous Operations

    #region Asynchronous Operations

    /// <summary>
    /// Get a list of chats
    /// </summary>
    /// <remarks>
    /// Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2007</returns>
    System.Threading.Tasks.Task<GetBotsChatsByBotIdResponse> ChatsGetAsync(string botId);

    /// <summary>
    /// Get a list of chats
    /// </summary>
    /// <remarks>
    /// Returns a list of chats with subscribers with information about the contact and the last message received from the contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
    System.Threading.Tasks.Task<ApiResponse<GetBotsChatsByBotIdResponse>> ChatsGetAsyncWithHttpInfo(
        string botId
    );

    /// <summary>
    /// Get a list of messages
    /// </summary>
    /// <remarks>
    /// Returns a list of all messages in correspondence with the specified subscriber
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2008</returns>
    System.Threading.Tasks.Task<PagedMessagesResponse> ChatsMessagesGetAsync(string contactId);

    /// <summary>
    /// Get a list of messages
    /// </summary>
    /// <remarks>
    /// Returns a list of all messages in correspondence with the specified subscriber
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<PagedMessagesResponse>
    > ChatsMessagesGetAsyncWithHttpInfo(string contactId);

    #endregion Asynchronous Operations
}
