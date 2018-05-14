# IO.Swagger.Model.Chunk
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Link** | **string** | The API link that can be used to obtain more information about this object | 
**Loaded** | **bool?** | True if this chunk is currently loaded, false otherwise | 
**Position** | [**Vector3i**](Vector3i.md) | The position of this chunk (in chunk coordinates) | 
**Uuid** | **Guid?** | The unique id of this chunk | 
**BlockMax** | [**Vector3i**](Vector3i.md) | The bock with the largest coordinates that is still part of this chunk | [optional] 
**BlockMin** | [**Vector3i**](Vector3i.md) | The bock with the smallest coordinates that is still part of this chunk | [optional] 
**InhabitedTime** | **int?** | The total amount of time (in server ticks) this chunk has been inhabited by players. | [optional] 
**RegionalDifficultyFactor** | **double?** | The increase in difficulty due to the presence of players in the chunk | [optional] 
**RegionalDifficultyPercentage** | **double?** | The increase in difficulty due to the presence of players in the chunk as a percentage | [optional] 
**World** | [**World**](World.md) | The world the chunk is in | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

