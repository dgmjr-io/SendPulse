/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: david@dgmjr.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
