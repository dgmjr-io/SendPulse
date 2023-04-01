# SendPulse.Api.CampaignsApi

All URIs are relative to *https://api.sendpulse.com/telegram*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CampaignsSendPost**](CampaignsApi.md#campaignssendpost) | **POST** /campaigns/send | Send campaign

<a name="campaignssendpost"></a>
# **CampaignsSendPost**
> InlineResponse20010 CampaignsSendPost (CampaignsSendBody body)

Send campaign

Sends a campaign to all of a bot's subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list

### Example
```csharp
using System;
using System.Diagnostics;
using SendPulse.Api;
using SendPulse.Api.Client;
using SendPulse.Api.Models;

namespace Example
{
    public class CampaignsSendPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oAuth2ClientCredentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CampaignsApi();
            var body = new CampaignsSendBody(); // CampaignsSendBody | 

            try
            {
                // Send campaign
                InlineResponse20010 result = apiInstance.CampaignsSendPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CampaignsApi.CampaignsSendPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CampaignsSendBody**](CampaignsSendBody.md)|  | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[oAuth2ClientCredentials](../README.md#oAuth2ClientCredentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
