# SendPulse.Api.Models.FlowsRunBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactId** | **string** | Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact. | 
**FlowId** | **string** | Flow ID to be launched. Can be obtained with the method of obtaining the list of flows | 
**ExternalData** | **object** | Custom variables. You can pass variable values in the request and use them once in the flow you selected. To add variables to the flow, in the Message element, insert the variable names as a JSON path expression {{$[&#x27;somekey&#x27;][&#x27;nestedkey&#x27;]}}. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
