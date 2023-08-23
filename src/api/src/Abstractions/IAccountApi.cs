/*
 * IAccountApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:39:32
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
public interface IAccountApi : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>InlineResponse20011</returns>
    AccountInfo AccountGet();

    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of InlineResponse20011</returns>
    ApiResponse<AccountInfo> AccountGetWithHttpInfo();
    #endregion Synchronous Operations
    #region Asynchronous Operations
    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of InlineResponse20011</returns>
    System.Threading.Tasks.Task<AccountInfo> AccountGetAsync();

    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
    System.Threading.Tasks.Task<ApiResponse<AccountInfo>> AccountGetAsyncWithHttpInfo();
    #endregion Asynchronous Operations
}
