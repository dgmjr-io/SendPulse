/*
 * IVariablesApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:37:38
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Abstractions;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IVariablesApi : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get a list of variables
    /// </summary>
    /// <remarks>
    /// Returns a list of variables for the selected bot with information about each: variable ID, bot ID, name, affiliation, type, status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2009</returns>
    InlineResponse2009 GetVariablesByBotId(string botId);

    /// <summary>
    /// Get a list of variables
    /// </summary>
    /// <remarks>
    /// Returns a list of variables for the selected bot with information about each: variable ID, bot ID, name, affiliation, type, status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2009</returns>
    ApiResponse<InlineResponse2009> VariablesGetWithHttpInfo(string botId);
    #endregion Synchronous Operations
    #region Asynchronous Operations
    /// <summary>
    /// Get a list of variables
    /// </summary>
    /// <remarks>
    /// Returns a list of variables for the selected bot with information about each: variable ID, bot ID, name, affiliation, type, status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2009</returns>
    System.Threading.Tasks.Task<InlineResponse2009> GetVariablesByBotIdAsync(string botId);

    /// <summary>
    /// Get a list of variables
    /// </summary>
    /// <remarks>
    /// Returns a list of variables for the selected bot with information about each: variable ID, bot ID, name, affiliation, type, status, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2009)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<InlineResponse2009>
    > GetVariablesByBoyIdAsyncWithHttpInfo(string botId);
    #endregion Asynchronous Operations
}
