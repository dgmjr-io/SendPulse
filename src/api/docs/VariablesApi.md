# SendPulse.Api.VariablesApi

All URIs are relative to *https://api.sendpulse.com/telegram*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VariablesGet**](VariablesApi.md#variablesget) | **GET** /variables | Get a list of variables

<a name="variablesget"></a>
# **VariablesGet**
> InlineResponse2009 VariablesGet (string botId)

Get a list of variables

Returns a list of variables for the selected bot with information about each: variable ID, bot ID, name, affiliation, type, status, and creation date

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class VariablesGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VariablesApi();
            var botId = botId_example;  // string | Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get a list of variables
                InlineResponse2009 result = apiInstance.VariablesGet(botId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariablesApi.VariablesGet: " + e.Message );
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

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
