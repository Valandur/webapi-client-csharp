# IO.Swagger.Model.BlockGetOperation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | **string** | The error message, if any | 
**EstimatedSecondsRemaining** | **float?** | The estimated amount of time remaining until this block operation is complete (in seconds) | 
**Link** | **string** | The API link that can be used to obtain more information about this object | 
**Max** | [**Vector3i**](Vector3i.md) | The maximum block belonging to this operation | 
**Min** | [**Vector3i**](Vector3i.md) | The minimum block belonging to this operation | 
**Progress** | **float?** | The current progress of the block operation, from 0 (&#x3D;started) to 1 (&#x3D;finished) | 
**Status** | **string** | The current status of the block operation | 
**Type** | **string** | The type of block operation | 
**Uuid** | **Guid?** | The unique UUID identifying this block operation | 
**World** | [**World**](World.md) | The world in which this block operation is running | 
**Blocks** | **List&lt;List&lt;List&lt;BlockState&gt;&gt;&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

