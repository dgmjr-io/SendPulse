# SendPulse.Api.ChatsApi

All URIs are relative to *https://api.sendpulse.com/telegram*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChatsGet**](ChatsApi.md#chatsget) | **GET** /chats | Get a list of chats
[**ChatsMessagesGet**](ChatsApi.md#chatsmessagesget) | **GET** /chats/messages | Get a list of messages

<a name="chatsget"></a>
# **ChatsGet**
> InlineResponse2007 ChatsGet (string botId)

Get a list of chats

Returns a list of chats with subscribers with information about the contact and the last message received from the contact

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ChatsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi();
            var botId = botId_example;  // string | Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get a list of chats
                InlineResponse2007 result = apiInstance.ChatsGet(botId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.ChatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **botId** | **string**| Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="chatsmessagesget"></a>
# **ChatsMessagesGet**
> InlineResponse2008 ChatsMessagesGet (string contactId)

Get a list of messages

Returns a list of all messages in correspondence with the specified subscriber

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class ChatsMessagesGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChatsApi();
            var contactId = contactId_example;  // string | Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get a list of messages
                InlineResponse2008 result = apiInstance.ChatsMessagesGet(contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChatsApi.ChatsMessagesGet: " + e.Message );
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

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
