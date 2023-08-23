/*
 * IBotsApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:39:25
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SendPulse.Api.Client;
using SendPulse.Api.Client.Abstractions;
using SendPulse.Api.Models;

namespace SendPulse.Api.Abstractions;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IBotsApi : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get a list of connected bots
    /// </summary>
    /// <remarks>
    /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>InlineResponse2005</returns>
    PagedApiResponse<Collection<Bot>> BotsGet();

    /// <summary>
    /// Get a list of connected bots
    /// </summary>
    /// <remarks>
    /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of InlineResponse2005</returns>
    ApiResponse<PagedApiResponse<Collection<Bot>>> BotsGetWithHttpInfo();

    /// <summary>
    /// Get general statistics info by bot
    /// </summary>
    /// <remarks>
    /// Returns general statistics info by bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2006</returns>
    PagedApiResponse<BotStatistics> BotsStatisticsGet(string botId);

    /// <summary>
    /// Get general statistics info by bot
    /// </summary>
    /// <remarks>
    /// Returns general statistics info by bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2006</returns>
    ApiResponse<PagedApiResponse<BotStatistics>> BotsStatisticsGetWithHttpInfo(string botId);
    #endregion Synchronous Operations
    #region Asynchronous Operations
    /// <summary>
    /// Get a list of connected bots
    /// </summary>
    /// <remarks>
    /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of InlineResponse2005</returns>
    System.Threading.Tasks.Task<PagedApiResponse<Collection<Bot>>> BotsGetAsync();

    /// <summary>
    /// Get a list of connected bots
    /// </summary>
    /// <remarks>
    /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<PagedApiResponse<Collection<Bot>>>
    > BotsGetAsyncWithHttpInfo();

    /// <summary>
    /// Get general statistics info by bot
    /// </summary>
    /// <remarks>
    /// Returns general statistics info by bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2006</returns>
    System.Threading.Tasks.Task<PagedApiResponse<BotStatistics>> BotsStatisticsGetAsync(
        string botId
    );

    /// <summary>
    /// Get general statistics info by bot
    /// </summary>
    /// <remarks>
    /// Returns general statistics info by bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<PagedApiResponse<BotStatistics>>
    > BotsStatisticsGetAsyncWithHttpInfo(string botId);
    #endregion Asynchronous Operations
}
