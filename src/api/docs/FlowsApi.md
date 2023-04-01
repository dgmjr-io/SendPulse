# SendPulse.Api.FlowsApi

All URIs are relative to *https://api.sendpulse.com/telegram*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FlowsGet**](FlowsApi.md#flowsget) | **GET** /flows | Get a list of flows
[**FlowsRunByTriggerPost**](FlowsApi.md#flowsrunbytriggerpost) | **POST** /flows/runByTrigger | Run a flow by trigger keywords
[**FlowsRunPost**](FlowsApi.md#flowsrunpost) | **POST** /flows/run | Run a flow by its ID

<a name="flowsget"></a>
# **FlowsGet**
> InlineResponse2003 FlowsGet (string botId)

Get a list of flows

Returns a list of created flows for the selected bot and information for each: flow id, bot id, status, name, id and name of the trigger that launches it, and creation date

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class FlowsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FlowsApi();
            var botId = botId_example;  // string | Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.

            try
            {
                // Get a list of flows
                InlineResponse2003 result = apiInstance.FlowsGet(botId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowsApi.FlowsGet: " + e.Message );
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

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flowsrunbytriggerpost"></a>
# **FlowsRunByTriggerPost**
> SuccessResponse FlowsRunByTriggerPost (FlowsRunByTriggerBody body)

Run a flow by trigger keywords

Launches a flow with the trigger keyword for the selected contact

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class FlowsRunByTriggerPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FlowsApi();
            var body = new FlowsRunByTriggerBody(); // FlowsRunByTriggerBody | 

            try
            {
                // Run a flow by trigger keywords
                SuccessResponse result = apiInstance.FlowsRunByTriggerPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowsApi.FlowsRunByTriggerPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlowsRunByTriggerBody**](FlowsRunByTriggerBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="flowsrunpost"></a>
# **FlowsRunPost**
> SuccessResponse FlowsRunPost (FlowsRunBody body)

Run a flow by its ID

Launches the selected flow for the selected contact.

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class FlowsRunPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FlowsApi();
            var body = new FlowsRunBody(); // FlowsRunBody | 

            try
            {
                // Run a flow by its ID
                SuccessResponse result = apiInstance.FlowsRunPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlowsApi.FlowsRunPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlowsRunBody**](FlowsRunBody.md)|  | 

### Return type

[**SuccessResponse**](SuccessResponse.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
