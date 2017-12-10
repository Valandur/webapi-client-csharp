# IO.Swagger.Model.BlockOperation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | The UUID of the block update operation. | [optional] 
**Type** | **string** | The type of action that is being performed by this operation. | [optional] 
**Status** | **string** | The current status of the operation, one of: INIT, RUNNING, PAUSED, DONE, ERRORED.  | [optional] 
**Progress** | **float?** | The update progress of this operation, from 0 (nothing done) to 1 (completely done). | [optional] 
**EstTimeRemaining** | **decimal?** | The estimated amount of seconds remaining before this operation is completed. | [optional] 
**Link** | **string** | The Web-API url to access for details about this operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

