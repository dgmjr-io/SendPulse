# SendPulse.Api.Models.CampaignsSendBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | Campaign title | 
**BotId** | **string** | Bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact. | 
**SendAt** | **string** | Specify the date and time in the format Y-m-d H:i if you need to schedule the campaign, if you do not specify this parameter, the campaign will be sent immediately | [optional] 
**Messages** | [**Collection&lt;CampaignssendMessages&gt;**](CampaignssendMessages.md) | Message to send, specifying the type and content of the campaign | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
