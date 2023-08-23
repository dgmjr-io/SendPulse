/*
 * ITriggersApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:37:24
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
public interface ITriggersApi : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get a list of triggers
    /// </summary>
    /// <remarks>
    /// Returns the list of created triggers for the selected bot with information about each of them: trigger ID, bot id, id of the flow that starts on it, name, type, set launch time and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2004</returns>
    InlineResponse2004 TriggersGet(string botId);

    /// <summary>
    /// Get a list of triggers
    /// </summary>
    /// <remarks>
    /// Returns the list of created triggers for the selected bot with information about each of them: trigger ID, bot id, id of the flow that starts on it, name, type, set launch time and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2004</returns>
    ApiResponse<InlineResponse2004> TriggersGetWithHttpInfo(string botId);
    #endregion Synchronous Operations
    #region Asynchronous Operations
    /// <summary>
    /// Get a list of triggers
    /// </summary>
    /// <remarks>
    /// Returns the list of created triggers for the selected bot with information about each of them: trigger ID, bot id, id of the flow that starts on it, name, type, set launch time and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2004</returns>
    System.Threading.Tasks.Task<InlineResponse2004> TriggersGetAsync(string botId);

    /// <summary>
    /// Get a list of triggers
    /// </summary>
    /// <remarks>
    /// Returns the list of created triggers for the selected bot with information about each of them: trigger ID, bot id, id of the flow that starts on it, name, type, set launch time and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
    System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> TriggersGetAsyncWithHttpInfo(
        string botId
    );
    #endregion Asynchronous Operations
}
