/*
 * IContactsApi.cs
 *
 *   Created: 2023-03-19-02:53:01
 *   Modified: 2023-08-23-05:38:55
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
public interface IContactsApi : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Resume autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Resumes autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsDeletePauseAutomationPost(ContactsDeletePauseAutomationBody body);

    /// <summary>
    /// Resume autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Resumes autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsDeletePauseAutomationPostWithHttpInfo(
        ContactsDeletePauseAutomationBody body
    );

    /// <summary>
    /// Delete contact
    /// </summary>
    /// <remarks>
    /// Removes a contact from the audience and subscribers list. The contact can be added back only by subscribing to the bot.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsDeletePost(ContactsDeleteBody body);

    /// <summary>
    /// Delete contact
    /// </summary>
    /// <remarks>
    /// Removes a contact from the audience and subscribers list. The contact can be added back only by subscribing to the bot.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsDeletePostWithHttpInfo(ContactsDeleteBody body);

    /// <summary>
    /// Remove a tag from a contact
    /// </summary>
    /// <remarks>
    /// Removes the tag for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsDeleteTagPost(ContactsDeleteTagBody body);

    /// <summary>
    /// Remove a tag from a contact
    /// </summary>
    /// <remarks>
    /// Removes the tag for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsDeleteTagPostWithHttpInfo(ContactsDeleteTagBody body);

    /// <summary>
    /// Delete a variable the selected contact
    /// </summary>
    /// <remarks>
    /// Delete the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsDeleteVariablePost(ContactsDeleteVariableBody body);

    /// <summary>
    /// Delete a variable the selected contact
    /// </summary>
    /// <remarks>
    /// Delete the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsDeleteVariablePostWithHttpInfo(
        ContactsDeleteVariableBody body
    );

    /// <summary>
    /// Disable contact
    /// </summary>
    /// <remarks>
    /// Disables a contact in your audience list. Campaigns and autoflows will not be sent to this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsDisablePost(ContactsDisableBody body);

    /// <summary>
    /// Disable contact
    /// </summary>
    /// <remarks>
    /// Disables a contact in your audience list. Campaigns and autoflows will not be sent to this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsDisablePostWithHttpInfo(ContactsDisableBody body);

    /// <summary>
    /// Enable contact
    /// </summary>
    /// <remarks>
    /// Enables a contact in the audience list and contact start receiving campaings and autoflows
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsEnablePost(ContactsEnableBody body);

    /// <summary>
    /// Enable contact
    /// </summary>
    /// <remarks>
    /// Enables a contact in the audience list and contact start receiving campaings and autoflows
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsEnablePostWithHttpInfo(ContactsEnableBody body);

    /// <summary>
    /// Get a list of contacts by tag
    /// </summary>
    /// <remarks>
    /// Returns a list of contacts by tag for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="tag">Created contact’s tag to search by</param>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse2001</returns>
    ContactsReceived ContactsGetByTagGet(string tag, string botId);

    /// <summary>
    /// Get a list of contacts by tag
    /// </summary>
    /// <remarks>
    /// Returns a list of contacts by tag for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="tag">Created contact’s tag to search by</param>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse2001</returns>
    ApiResponse<ContactsReceived> ContactsGetByTagGetWithHttpInfo(string tag, string botId);

    /// <summary>
    /// Get contacts by variable
    /// </summary>
    /// <remarks>
    /// Returns contacts by variable identifier or variable name for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="variableValue">Contact&#x27;s variable value</param>
    /// <param name="variableId">Contact’s variable ID to search by; required parameter if you do not pass variable_name and bot_id. (optional)</param>
    /// <param name="variableName">Contact’s variable name to search by; required parameter and passed with the bot_id parameter, if you do not pass variable_id. (optional)</param>
    /// <param name="botId">Bot ID; required parameter and passed with the variable_name parameter, if you do not pass variable_id. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. (optional)</param>
    /// <returns>InlineResponse2001</returns>
    ContactsReceived ContactsGetByVariableGet(
        string variableValue,
        string variableId = null,
        string variableName = null,
        string botId = null
    );

    /// <summary>
    /// Get contacts by variable
    /// </summary>
    /// <remarks>
    /// Returns contacts by variable identifier or variable name for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="variableValue">Contact&#x27;s variable value</param>
    /// <param name="variableId">Contact’s variable ID to search by; required parameter if you do not pass variable_name and bot_id. (optional)</param>
    /// <param name="variableName">Contact’s variable name to search by; required parameter and passed with the bot_id parameter, if you do not pass variable_id. (optional)</param>
    /// <param name="botId">Bot ID; required parameter and passed with the variable_name parameter, if you do not pass variable_id. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. (optional)</param>
    /// <returns>ApiResponse of InlineResponse2001</returns>
    ApiResponse<ContactsReceived> ContactsGetByVariableGetWithHttpInfo(
        string variableValue,
        string variableId = null,
        string variableName = null,
        string botId = null
    );

    /// <summary>
    /// Get contact info via a contact ID
    /// </summary>
    /// <remarks>
    /// Returns information on the selected contact: bot and contact ID, information from messenger, list of tags and variables, activity data and date added
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>InlineResponse200</returns>
    ContactReceived ContactsGetGet(string id);

    /// <summary>
    /// Get contact info via a contact ID
    /// </summary>
    /// <remarks>
    /// Returns information on the selected contact: bot and contact ID, information from messenger, list of tags and variables, activity data and date added
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of InlineResponse200</returns>
    ApiResponse<ContactReceived> ContactsGetGetWithHttpInfo(string id);

    /// <summary>
    /// Get remaining time for automation pause
    /// </summary>
    /// <remarks>
    /// Returns the time remaining until autoflows are stopped for this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsGetPauseAutomationGet(string contactId);

    /// <summary>
    /// Get remaining time for automation pause
    /// </summary>
    /// <remarks>
    /// Returns the time remaining until autoflows are stopped for this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsGetPauseAutomationGetWithHttpInfo(string contactId);

    /// <summary>
    /// Mark messages as read
    /// </summary>
    /// <remarks>
    /// Mark contact all messages as read (set unread count 0)
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact’s ID for set unread count as 0 (optional)</param>
    /// <returns>InlineResponse2002</returns>
    MarkReadResult ContactsMarkReadPut(string contactId = null);

    /// <summary>
    /// Mark messages as read
    /// </summary>
    /// <remarks>
    /// Mark contact all messages as read (set unread count 0)
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact’s ID for set unread count as 0 (optional)</param>
    /// <returns>ApiResponse of InlineResponse2002</returns>
    ApiResponse<MarkReadResult> ContactsMarkReadPutWithHttpInfo(string contactId = null);

    /// <summary>
    /// Send a message to a contact
    /// </summary>
    /// <remarks>
    /// Sends a text message, image, or a file  to contact with the specified contact ID.  To view an example of the request body, select a message type from the drop-down list
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsSendPost(ContactsSendBody body);

    /// <summary>
    /// Send a message to a contact
    /// </summary>
    /// <remarks>
    /// Sends a text message, image, or a file  to contact with the specified contact ID.  To view an example of the request body, select a message type from the drop-down list
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsSendPostWithHttpInfo(ContactsSendBody body);

    /// <summary>
    /// Sends a text message to the specified contact
    /// </summary>
    /// <remarks>
    /// Sends a text message to the specified contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsSendTextPost(ContactsSendTextBody body);

    /// <summary>
    /// Sends a text message to the specified contact
    /// </summary>
    /// <remarks>
    /// Sends a text message to the specified contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsSendTextPostWithHttpInfo(ContactsSendTextBody body);

    /// <summary>
    /// Pause autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Pauses autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsSetPauseAutomationPost(ContactsSetPauseAutomationBody body);

    /// <summary>
    /// Pause autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Pauses autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsSetPauseAutomationPostWithHttpInfo(
        ContactsSetPauseAutomationBody body
    );

    /// <summary>
    /// Assign a tag to contact
    /// </summary>
    /// <remarks>
    /// Assigns tags to the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsSetTagPost(ContactsSetTagBody body);

    /// <summary>
    /// Assign a tag to contact
    /// </summary>
    /// <remarks>
    /// Assigns tags to the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsSetTagPostWithHttpInfo(ContactsSetTagBody body);

    /// <summary>
    /// Assign a variable to contact
    /// </summary>
    /// <remarks>
    /// Adds or updates the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>SuccessResponse</returns>
    SuccessResponse ContactsSetVariablePost(ContactsSetVariableBody body);

    /// <summary>
    /// Assign a variable to contact
    /// </summary>
    /// <remarks>
    /// Adds or updates the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>ApiResponse of SuccessResponse</returns>
    ApiResponse<SuccessResponse> ContactsSetVariablePostWithHttpInfo(ContactsSetVariableBody body);
    #endregion Synchronous Operations
    #region Asynchronous Operations
    /// <summary>
    /// Resume autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Resumes autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsDeletePauseAutomationPostAsync(
        ContactsDeletePauseAutomationBody body
    );

    /// <summary>
    /// Resume autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Resumes autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > ContactsDeletePauseAutomationPostAsyncWithHttpInfo(ContactsDeletePauseAutomationBody body);

    /// <summary>
    /// Delete contact
    /// </summary>
    /// <remarks>
    /// Removes a contact from the audience and subscribers list. The contact can be added back only by subscribing to the bot.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsDeletePostAsync(ContactsDeleteBody body);

    /// <summary>
    /// Delete contact
    /// </summary>
    /// <remarks>
    /// Removes a contact from the audience and subscribers list. The contact can be added back only by subscribing to the bot.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> ContactsDeletePostAsyncWithHttpInfo(
        ContactsDeleteBody body
    );

    /// <summary>
    /// Remove a tag from a contact
    /// </summary>
    /// <remarks>
    /// Removes the tag for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsDeleteTagPostAsync(
        ContactsDeleteTagBody body
    );

    /// <summary>
    /// Remove a tag from a contact
    /// </summary>
    /// <remarks>
    /// Removes the tag for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > ContactsDeleteTagPostAsyncWithHttpInfo(ContactsDeleteTagBody body);

    /// <summary>
    /// Delete a variable the selected contact
    /// </summary>
    /// <remarks>
    /// Delete the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsDeleteVariablePostAsync(
        ContactsDeleteVariableBody body
    );

    /// <summary>
    /// Delete a variable the selected contact
    /// </summary>
    /// <remarks>
    /// Delete the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > ContactsDeleteVariablePostAsyncWithHttpInfo(ContactsDeleteVariableBody body);

    /// <summary>
    /// Disable contact
    /// </summary>
    /// <remarks>
    /// Disables a contact in your audience list. Campaigns and autoflows will not be sent to this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsDisablePostAsync(ContactsDisableBody body);

    /// <summary>
    /// Disable contact
    /// </summary>
    /// <remarks>
    /// Disables a contact in your audience list. Campaigns and autoflows will not be sent to this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> ContactsDisablePostAsyncWithHttpInfo(
        ContactsDisableBody body
    );

    /// <summary>
    /// Enable contact
    /// </summary>
    /// <remarks>
    /// Enables a contact in the audience list and contact start receiving campaings and autoflows
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsEnablePostAsync(ContactsEnableBody body);

    /// <summary>
    /// Enable contact
    /// </summary>
    /// <remarks>
    /// Enables a contact in the audience list and contact start receiving campaings and autoflows
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> ContactsEnablePostAsyncWithHttpInfo(
        ContactsEnableBody body
    );

    /// <summary>
    /// Get a list of contacts by tag
    /// </summary>
    /// <remarks>
    /// Returns a list of contacts by tag for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="tag">Created contact’s tag to search by</param>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse2001</returns>
    System.Threading.Tasks.Task<ContactsReceived> ContactsGetByTagGetAsync(
        string tag,
        string botId
    );

    /// <summary>
    /// Get a list of contacts by tag
    /// </summary>
    /// <remarks>
    /// Returns a list of contacts by tag for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="tag">Created contact’s tag to search by</param>
    /// <param name="botId">Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
    System.Threading.Tasks.Task<ApiResponse<ContactsReceived>> ContactsGetByTagGetAsyncWithHttpInfo(
        string tag,
        string botId
    );

    /// <summary>
    /// Get contacts by variable
    /// </summary>
    /// <remarks>
    /// Returns contacts by variable identifier or variable name for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="variableValue">Contact&#x27;s variable value</param>
    /// <param name="variableId">Contact’s variable ID to search by; required parameter if you do not pass variable_name and bot_id. (optional)</param>
    /// <param name="variableName">Contact’s variable name to search by; required parameter and passed with the bot_id parameter, if you do not pass variable_id. (optional)</param>
    /// <param name="botId">Bot ID; required parameter and passed with the variable_name parameter, if you do not pass variable_id. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. (optional)</param>
    /// <returns>Task of InlineResponse2001</returns>
    System.Threading.Tasks.Task<ContactsReceived> ContactsGetByVariableGetAsync(
        string variableValue,
        string variableId = null,
        string variableName = null,
        string botId = null
    );

    /// <summary>
    /// Get contacts by variable
    /// </summary>
    /// <remarks>
    /// Returns contacts by variable identifier or variable name for the specified bot
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="variableValue">Contact&#x27;s variable value</param>
    /// <param name="variableId">Contact’s variable ID to search by; required parameter if you do not pass variable_name and bot_id. (optional)</param>
    /// <param name="variableName">Contact’s variable name to search by; required parameter and passed with the bot_id parameter, if you do not pass variable_id. (optional)</param>
    /// <param name="botId">Bot ID; required parameter and passed with the variable_name parameter, if you do not pass variable_id. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. (optional)</param>
    /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<ContactsReceived>
    > ContactsGetByVariableGetAsyncWithHttpInfo(
        string variableValue,
        string variableId = null,
        string variableName = null,
        string botId = null
    );

    /// <summary>
    /// Get contact info via a contact ID
    /// </summary>
    /// <remarks>
    /// Returns information on the selected contact: bot and contact ID, information from messenger, list of tags and variables, activity data and date added
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of InlineResponse200</returns>
    System.Threading.Tasks.Task<ContactReceived> ContactsGetGetAsync(string id);

    /// <summary>
    /// Get contact info via a contact ID
    /// </summary>
    /// <remarks>
    /// Returns information on the selected contact: bot and contact ID, information from messenger, list of tags and variables, activity data and date added
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (InlineResponse200)</returns>
    System.Threading.Tasks.Task<ApiResponse<ContactReceived>> ContactsGetGetAsyncWithHttpInfo(
        string id
    );

    /// <summary>
    /// Get remaining time for automation pause
    /// </summary>
    /// <remarks>
    /// Returns the time remaining until autoflows are stopped for this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsGetPauseAutomationGetAsync(
        string contactId
    );

    /// <summary>
    /// Get remaining time for automation pause
    /// </summary>
    /// <remarks>
    /// Returns the time remaining until autoflows are stopped for this contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > ContactsGetPauseAutomationGetAsyncWithHttpInfo(string contactId);

    /// <summary>
    /// Mark messages as read
    /// </summary>
    /// <remarks>
    /// Mark contact all messages as read (set unread count 0)
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact’s ID for set unread count as 0 (optional)</param>
    /// <returns>Task of InlineResponse2002</returns>
    System.Threading.Tasks.Task<MarkReadResult> ContactsMarkReadPutAsync(string contactId = null);

    /// <summary>
    /// Mark messages as read
    /// </summary>
    /// <remarks>
    /// Mark contact all messages as read (set unread count 0)
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="contactId">Contact’s ID for set unread count as 0 (optional)</param>
    /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
    System.Threading.Tasks.Task<ApiResponse<MarkReadResult>> ContactsMarkReadPutAsyncWithHttpInfo(
        string contactId = null
    );

    /// <summary>
    /// Send a message to a contact
    /// </summary>
    /// <remarks>
    /// Sends a text message, image, or a file  to contact with the specified contact ID.  To view an example of the request body, select a message type from the drop-down list
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsSendPostAsync(ContactsSendBody body);

    /// <summary>
    /// Send a message to a contact
    /// </summary>
    /// <remarks>
    /// Sends a text message, image, or a file  to contact with the specified contact ID.  To view an example of the request body, select a message type from the drop-down list
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> ContactsSendPostAsyncWithHttpInfo(
        ContactsSendBody body
    );

    /// <summary>
    /// Sends a text message to the specified contact
    /// </summary>
    /// <remarks>
    /// Sends a text message to the specified contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsSendTextPostAsync(
        ContactsSendTextBody body
    );

    /// <summary>
    /// Sends a text message to the specified contact
    /// </summary>
    /// <remarks>
    /// Sends a text message to the specified contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> ContactsSendTextPostAsyncWithHttpInfo(
        ContactsSendTextBody body
    );

    /// <summary>
    /// Pause autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Pauses autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsSetPauseAutomationPostAsync(
        ContactsSetPauseAutomationBody body
    );

    /// <summary>
    /// Pause autoflows for a contact
    /// </summary>
    /// <remarks>
    /// Pauses autoflows for the specified contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > ContactsSetPauseAutomationPostAsyncWithHttpInfo(ContactsSetPauseAutomationBody body);

    /// <summary>
    /// Assign a tag to contact
    /// </summary>
    /// <remarks>
    /// Assigns tags to the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsSetTagPostAsync(ContactsSetTagBody body);

    /// <summary>
    /// Assign a tag to contact
    /// </summary>
    /// <remarks>
    /// Assigns tags to the selected contact
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body"></param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> ContactsSetTagPostAsyncWithHttpInfo(
        ContactsSetTagBody body
    );

    /// <summary>
    /// Assign a variable to contact
    /// </summary>
    /// <remarks>
    /// Adds or updates the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>Task of SuccessResponse</returns>
    System.Threading.Tasks.Task<SuccessResponse> ContactsSetVariablePostAsync(
        ContactsSetVariableBody body
    );

    /// <summary>
    /// Assign a variable to contact
    /// </summary>
    /// <remarks>
    /// Adds or updates the value of a variable for the selected contact.
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="body">Choose one of available request body</param>
    /// <returns>Task of ApiResponse (SuccessResponse)</returns>
    System.Threading.Tasks.Task<
        ApiResponse<SuccessResponse>
    > ContactsSetVariablePostAsyncWithHttpInfo(ContactsSetVariableBody body);
    #endregion Asynchronous Operations
}
