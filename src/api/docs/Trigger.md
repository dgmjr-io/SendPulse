# SendPulse.Api.Models.Trigger
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BotId** | **string** |  | [optional] 
**FlowId** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Type** | **int?** |                      * &#x60;1&#x60; - starts immediately upon subscription                      * &#x60;2&#x60; - starts when unsubscribed                      * &#x60;3&#x60; - default reply                      * &#x60;4&#x60; - starts when the specified keyword is entered                      * &#x60;5&#x60; - starts at the specified time when subscribing                   | [optional] 
**Status** | **int?** |                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                   | [optional] 
**Keywords** | **Collection&lt;string&gt;** |  | [optional] 
**Execution** | [**TriggerExecution**](TriggerExecution.md) |  | [optional] 
**CreatedAt** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
