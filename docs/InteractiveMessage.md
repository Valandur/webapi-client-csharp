# IO.Swagger.Model.InteractiveMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the message. Used for sender of the message to identify responses. | 
**Link** | **string** | The API link that can be used to obtain more information about this object | 
**Target** | **string** | The target of the message, usually this is a player UUID. Can be set to \&quot;server\&quot; to send to all online players. | 
**Uuid** | **Guid?** | The unique UUID of this message | 
**Message** | **string** | The actual content of the message | [optional] 
**Once** | **bool?** | True if this message can only be replied to once per target, false otherwise | [optional] 
**Options** | [**List&lt;InteractiveMessageOption&gt;**](InteractiveMessageOption.md) | Clickable options that the player can select from | [optional] 
**Targets** | **List&lt;string&gt;** | A list of targets that will receive the message. Usually a list of player UUIDs | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

