# SendPulse.Api.TriggersApi

All URIs are relative to *https://api.sendpulse.com/telegram*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TriggersGet**](TriggersApi.md#triggersget) | **GET** /triggers | Get a list of triggers

<a name="triggersget"></a>
# **TriggersGet**
> InlineResponse2004 TriggersGet (string botId)

Get a list of triggers

Returns the list of created triggers for the selected bot with information about each of them: trigger ID, bot id, id of the flow that starts on it, name, type, set launch time and creation date

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class TriggersGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TriggersApi();
            var botId = botId_example;  // string | Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get a list of triggers
                InlineResponse2004 result = apiInstance.TriggersGet(botId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TriggersApi.TriggersGet: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
