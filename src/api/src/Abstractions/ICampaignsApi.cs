/*
 * ICampaignsApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:39:16
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using SendPulse.Api.Client;
using SendPulse.Api.Client.Abstractions;
using SendPulse.Api.Models;

namespace SendPulse.Api.Abstractions
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICampaignsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 CampaignsSendPost(CampaignsSendBody body);

        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        ApiResponse<InlineResponse20010> CampaignsSendPostWithHttpInfo(CampaignsSendBody body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> CampaignsSendPostAsync(
            CampaignsSendBody body
        );

        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        System.Threading.Tasks.Task<
            ApiResponse<InlineResponse20010>
        > CampaignsSendPostAsyncWithHttpInfo(CampaignsSendBody body);
        #endregion Asynchronous Operations
    }
}
