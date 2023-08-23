/*
 * IFlowsApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:38:47
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
public interface IFlowsApi : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get a list of flows
    /// </summary>
    /// <remarks>
    /// Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2003</returns>
    GetFlowsByBotResponse GetFlowsByBot(string botId);

    /// <summary>
    /// Get a list of flows
    /// </summary>
    /// <remarks>
    /// Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2003</returns>
    ApiResponse<GetFlowsByBotResponse> FlowsGetWithHttpInfo(string botId);

    /// <summary>
    /// Run a flow by trigger keywords
    /// </summary>
    /// <remarks>
    /// Launches a flow with the trigger keyword for the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse FlowsRunByTriggerPost(FlowsRunByTriggerBody body);

    /// <summary>
    /// Run a flow by trigger keywords
    /// </summary>
    /// <remarks>
    /// Launches a flow with the trigger keyword for the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> FlowsRunByTriggerPostWithHttpInfo(FlowsRunByTriggerBody body);

    /// <summary>
    /// Run a flow by its ID
    /// </summary>
    /// <remarks>
    /// Launches the selected flow for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse FlowsRunPost(FlowsRunBody body);

    /// <summary>
    /// Run a flow by its ID
    /// </summary>
    /// <remarks>
    /// Launches the selected flow for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> FlowsRunPostWithHttpInfo(FlowsRunBody body);
    #endregion Synchronous Operations
    #region Asynchronous Operations
    /// <summary>
    /// Get a list of flows
    /// </summary>
    /// <remarks>
    /// Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2003</returns>
    System.Threading.Tasks.Task<GetFlowsByBotResponse> FlowsGetAsync(string botId);

    /// <summary>
    /// Get a list of flows
    /// </summary>
    /// <remarks>
    /// Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
    System.Threading.Tasks.Task<ApiResponse<GetFlowsByBotResponse>> FlowsGetAsyncWithHttpInfo(
        string botId
    );

    /// <summary>
    /// Run a flow by trigger keywords
    /// </summary>
    /// <remarks>
    /// Launches a flow with the trigger keyword for the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> FlowsRunByTriggerPostAsync(
        FlowsRunByTriggerBody body
    );

    /// <summary>
    /// Run a flow by trigger keywords
    /// </summary>
    /// <remarks>
    /// Launches a flow with the trigger keyword for the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > FlowsRunByTriggerPostAsyncWithHttpInfo(FlowsRunByTriggerBody body);

    /// <summary>
    /// Run a flow by its ID
    /// </summary>
    /// <remarks>
    /// Launches the selected flow for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> FlowsRunPostAsync(FlowsRunBody body);

    /// <summary>
    /// Run a flow by its ID
    /// </summary>
    /// <remarks>
    /// Launches the selected flow for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> FlowsRunPostAsyncWithHttpInfo(
        FlowsRunBody body
    );
    #endregion Asynchronous Operations
}
