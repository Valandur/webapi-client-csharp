# IO.Swagger.Model.CreateBlockOperationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Max** | [**Vector3i**](Vector3i.md) | The maximum world coordinates spanning the cube where the operation is run | 
**Min** | [**Vector3i**](Vector3i.md) | The minimum world coordinates spanning the cube where the operation is run | 
**Type** | **string** | The type of the block operation | 
**World** | **string** | The world that the operation is run in | 
**Block** | [**BlockState**](BlockState.md) | The block that we want to change all other blocks into (when using an UPDATE operation | [optional] 
**Blocks** | **List&lt;List&lt;List&lt;BlockState&gt;&gt;&gt;** | An array of blocks defining what each block in the spanned cube | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

