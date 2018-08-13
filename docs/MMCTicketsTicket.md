# IO.Swagger.Model.MMCTicketsTicket
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The unique id of this ticket | 
**Link** | **string** | The API link that can be used to obtain more information about this object | 
**Message** | **string** | The message sent along with this ticket | 
**Status** | **string** | The current status of the ticket | 
**Timestamp** | **long?** | The unix timestamp (in seconds) when this ticket was submitted | 
**Comment** | **string** | The comment added by staff to this ticket | [optional] 
**Location** | [**Location**](Location.md) | The location at which this ticket was submitted | [optional] 
**Notified** | **int?** | True if staff has been notified about this ticket, false otherwise | [optional] 
**Sender** | [**Player**](Player.md) | The sender of this ticket | [optional] 
**Staff** | [**Player**](Player.md) | The staff member that was assigned to this ticket | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

