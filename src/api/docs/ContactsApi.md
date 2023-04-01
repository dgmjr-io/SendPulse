# SendPulse.Api.ContactsApi

All URIs are relative to *https://api.sendpulse.com/telegram*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactsDeletePauseAutomationPost**](ContactsApi.md#contactsdeletepauseautomationpost) | **POST** /contacts/deletePauseAutomation | Resume autoflows for a contact
[**ContactsDeletePost**](ContactsApi.md#contactsdeletepost) | **POST** /contacts/delete | Delete contact
[**ContactsDeleteTagPost**](ContactsApi.md#contactsdeletetagpost) | **POST** /contacts/deleteTag | Remove a tag from a contact
[**ContactsDeleteVariablePost**](ContactsApi.md#contactsdeletevariablepost) | **POST** /contacts/deleteVariable | Delete a variable the selected contact
[**ContactsDisablePost**](ContactsApi.md#contactsdisablepost) | **POST** /contacts/disable | Disable contact
[**ContactsEnablePost**](ContactsApi.md#contactsenablepost) | **POST** /contacts/enable | Enable contact
[**ContactsGetByTagGet**](ContactsApi.md#contactsgetbytagget) | **GET** /contacts/getByTag | Get a list of contacts by tag
[**ContactsGetByVariableGet**](ContactsApi.md#contactsgetbyvariableget) | **GET** /contacts/getByVariable | Get contacts by variable
[**ContactsGetGet**](ContactsApi.md#contactsgetget) | **GET** /contacts/get | Get contact info via a contact ID
[**ContactsGetPauseAutomationGet**](ContactsApi.md#contactsgetpauseautomationget) | **GET** /contacts/getPauseAutomation | Get remaining time for automation pause
[**ContactsMarkReadPut**](ContactsApi.md#contactsmarkreadput) | **PUT** /contacts/mark-read | Mark messages as read
[**ContactsSendPost**](ContactsApi.md#contactssendpost) | **POST** /contacts/send | Send a message to a contact
[**ContactsSendTextPost**](ContactsApi.md#contactssendtextpost) | **POST** /contacts/sendText | Sends a text message to the specified contact
[**ContactsSetPauseAutomationPost**](ContactsApi.md#contactssetpauseautomationpost) | **POST** /contacts/setPauseAutomation | Pause autoflows for a contact
[**ContactsSetTagPost**](ContactsApi.md#contactssettagpost) | **POST** /contacts/setTag | Assign a tag to contact
[**ContactsSetVariablePost**](ContactsApi.md#contactssetvariablepost) | **POST** /contacts/setVariable | Assign a variable to contact

<a name="contactsdeletepauseautomationpost"></a>
# **ContactsDeletePauseAutomationPost**
> SuccessResponse ContactsDeletePauseAutomationPost (ContactsDeletePauseAutomationBody body)

Resume autoflows for a contact

Resumes autoflows for the specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsDeletePauseAutomationPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsDeletePauseAutomationBody(); // ContactsDeletePauseAutomationBody | 

            try
            {
                // Resume autoflows for a contact
                SuccessResponse result = apiInstance.ContactsDeletePauseAutomationPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeletePauseAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsDeletePauseAutomationBody**](ContactsDeletePauseAutomationBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsdeletepost"></a>
# **ContactsDeletePost**
> SuccessResponse ContactsDeletePost (ContactsDeleteBody body)

Delete contact

Removes a contact from the audience and subscribers list. The contact can be added back only by subscribing to the bot.

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsDeletePostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsDeleteBody(); // ContactsDeleteBody | 

            try
            {
                // Delete contact
                SuccessResponse result = apiInstance.ContactsDeletePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsDeleteBody**](ContactsDeleteBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsdeletetagpost"></a>
# **ContactsDeleteTagPost**
> SuccessResponse ContactsDeleteTagPost (ContactsDeleteTagBody body)

Remove a tag from a contact

Removes the tag for the selected contact.

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsDeleteTagPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsDeleteTagBody(); // ContactsDeleteTagBody | 

            try
            {
                // Remove a tag from a contact
                SuccessResponse result = apiInstance.ContactsDeleteTagPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeleteTagPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsDeleteTagBody**](ContactsDeleteTagBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsdeletevariablepost"></a>
# **ContactsDeleteVariablePost**
> SuccessResponse ContactsDeleteVariablePost (ContactsDeleteVariableBody body)

Delete a variable the selected contact

Delete the value of a variable for the selected contact.

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsDeleteVariablePostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsDeleteVariableBody(); // ContactsDeleteVariableBody | Choose one of available request body

            try
            {
                // Delete a variable the selected contact
                SuccessResponse result = apiInstance.ContactsDeleteVariablePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDeleteVariablePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsDeleteVariableBody**](ContactsDeleteVariableBody.md)| Choose one of available request body | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsdisablepost"></a>
# **ContactsDisablePost**
> SuccessResponse ContactsDisablePost (ContactsDisableBody body)

Disable contact

Disables a contact in your audience list. Campaigns and autoflows will not be sent to this contact

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsDisablePostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsDisableBody(); // ContactsDisableBody | 

            try
            {
                // Disable contact
                SuccessResponse result = apiInstance.ContactsDisablePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsDisablePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsDisableBody**](ContactsDisableBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsenablepost"></a>
# **ContactsEnablePost**
> SuccessResponse ContactsEnablePost (ContactsEnableBody body)

Enable contact

Enables a contact in the audience list and contact start receiving campaings and autoflows

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsEnablePostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsEnableBody(); // ContactsEnableBody | 

            try
            {
                // Enable contact
                SuccessResponse result = apiInstance.ContactsEnablePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsEnablePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsEnableBody**](ContactsEnableBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsgetbytagget"></a>
# **ContactsGetByTagGet**
> InlineResponse2001 ContactsGetByTagGet (string tag, string botId)

Get a list of contacts by tag

Returns a list of contacts by tag for the specified bot

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsGetByTagGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var tag = tag_example;  // string | Created contact’s tag to search by
            var botId = botId_example;  // string | Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get a list of contacts by tag
                InlineResponse2001 result = apiInstance.ContactsGetByTagGet(tag, botId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetByTagGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| Created contact’s tag to search by | 
 **botId** | **string**| Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsgetbyvariableget"></a>
# **ContactsGetByVariableGet**
> InlineResponse2001 ContactsGetByVariableGet (string variableValue, string variableId = null, string variableName = null, string botId = null)

Get contacts by variable

Returns contacts by variable identifier or variable name for the specified bot

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsGetByVariableGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var variableValue = variableValue_example;  // string | Contact's variable value
            var variableId = variableId_example;  // string | Contact’s variable ID to search by; required parameter if you do not pass variable_name and bot_id. (optional) 
            var variableName = variableName_example;  // string | Contact’s variable name to search by; required parameter and passed with the bot_id parameter, if you do not pass variable_id. (optional) 
            var botId = botId_example;  // string | Bot ID; required parameter and passed with the variable_name parameter, if you do not pass variable_id. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. (optional) 

            try
            {
                // Get contacts by variable
                InlineResponse2001 result = apiInstance.ContactsGetByVariableGet(variableValue, variableId, variableName, botId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetByVariableGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **variableValue** | **string**| Contact&#x27;s variable value | 
 **variableId** | **string**| Contact’s variable ID to search by; required parameter if you do not pass variable_name and bot_id. | [optional] 
 **variableName** | **string**| Contact’s variable name to search by; required parameter and passed with the bot_id parameter, if you do not pass variable_id. | [optional] 
 **botId** | **string**| Bot ID; required parameter and passed with the variable_name parameter, if you do not pass variable_id. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsgetget"></a>
# **ContactsGetGet**
> InlineResponse200 ContactsGetGet (string id)

Get contact info via a contact ID

Returns information on the selected contact: bot and contact ID, information from messenger, list of tags and variables, activity data and date added

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsGetGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var id = id_example;  // string | Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get contact info via a contact ID
                InlineResponse200 result = apiInstance.ContactsGetGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact. | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsgetpauseautomationget"></a>
# **ContactsGetPauseAutomationGet**
> SuccessResponse ContactsGetPauseAutomationGet (string contactId)

Get remaining time for automation pause

Returns the time remaining until autoflows are stopped for this contact 

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsGetPauseAutomationGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var contactId = contactId_example;  // string | Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get remaining time for automation pause
                SuccessResponse result = apiInstance.ContactsGetPauseAutomationGet(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsGetPauseAutomationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact. | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactsmarkreadput"></a>
# **ContactsMarkReadPut**
> InlineResponse2002 ContactsMarkReadPut (string contactId = null)

Mark messages as read

Mark contact all messages as read (set unread count 0)

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsMarkReadPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var contactId = contactId_example;  // string | Contact’s ID for set unread count as 0 (optional) 

            try
            {
                // Mark messages as read
                InlineResponse2002 result = apiInstance.ContactsMarkReadPut(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsMarkReadPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactId** | **string**| Contact’s ID for set unread count as 0 | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactssendpost"></a>
# **ContactsSendPost**
> SuccessResponse ContactsSendPost (ContactsSendBody body)

Send a message to a contact

Sends a text message, image, or a file  to contact with the specified contact ID.  To view an example of the request body, select a message type from the drop-down list

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsSendPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsSendBody(); // ContactsSendBody | 

            try
            {
                // Send a message to a contact
                SuccessResponse result = apiInstance.ContactsSendPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsSendBody**](ContactsSendBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactssendtextpost"></a>
# **ContactsSendTextPost**
> SuccessResponse ContactsSendTextPost (ContactsSendTextBody body)

Sends a text message to the specified contact

Sends a text message to the specified contact.

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsSendTextPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsSendTextBody(); // ContactsSendTextBody | 

            try
            {
                // Sends a text message to the specified contact
                SuccessResponse result = apiInstance.ContactsSendTextPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSendTextPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsSendTextBody**](ContactsSendTextBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactssetpauseautomationpost"></a>
# **ContactsSetPauseAutomationPost**
> SuccessResponse ContactsSetPauseAutomationPost (ContactsSetPauseAutomationBody body)

Pause autoflows for a contact

Pauses autoflows for the specified contact

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsSetPauseAutomationPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsSetPauseAutomationBody(); // ContactsSetPauseAutomationBody | 

            try
            {
                // Pause autoflows for a contact
                SuccessResponse result = apiInstance.ContactsSetPauseAutomationPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetPauseAutomationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsSetPauseAutomationBody**](ContactsSetPauseAutomationBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactssettagpost"></a>
# **ContactsSetTagPost**
> SuccessResponse ContactsSetTagPost (ContactsSetTagBody body)

Assign a tag to contact

Assigns tags to the selected contact

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsSetTagPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsSetTagBody(); // ContactsSetTagBody | 

            try
            {
                // Assign a tag to contact
                SuccessResponse result = apiInstance.ContactsSetTagPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetTagPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsSetTagBody**](ContactsSetTagBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="contactssetvariablepost"></a>
# **ContactsSetVariablePost**
> SuccessResponse ContactsSetVariablePost (ContactsSetVariableBody body)

Assign a variable to contact

Adds or updates the value of a variable for the selected contact.

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ContactsSetVariablePostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new ContactsSetVariableBody(); // ContactsSetVariableBody | Choose one of available request body

            try
            {
                // Assign a variable to contact
                SuccessResponse result = apiInstance.ContactsSetVariablePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ContactsSetVariablePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContactsSetVariableBody**](ContactsSetVariableBody.md)| Choose one of available request body | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
