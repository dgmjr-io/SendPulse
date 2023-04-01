# SendPulse.Api.Models.Contact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BotId** | **string** |  | [optional] 
**Status** | **int?** |                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - unsubscribed                      * &#x60;3&#x60; - disabled                      * &#x60;4&#x60; - blocked by user                   | [optional] 
**ChannelData** | [**ContactChannelData**](ContactChannelData.md) |  | [optional] 
**Tags** | **Collection&lt;string&gt;** |  | [optional] 
**Variables** | **object** | variable_name: variable_value | [optional] 
**IsChatOpened** | **bool?** |  | [optional] 
**LastActivityAt** | **string** |  | [optional] 
**AutomationPausedUntil** | **string** |  | [optional] 
**CreatedAt** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
