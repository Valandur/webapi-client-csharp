# IO.Swagger.Model.NationsZone
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | The unique uuid of this zone. | [optional] 
**Name** | **string** | The name of the zone. | [optional] 
**Rect** | [**NationsRect**](NationsRect.md) |  | [optional] 
**Owner** | [**Player**](Player.md) |  | [optional] 
**CoOwners** | [**List&lt;Player&gt;**](Player.md) | The list of co-owners of this zone. | [optional] 
**Flags** | **Object** | A map of boolean flags. | [optional] 
**ForSale** | **bool?** | True if this zone is for sale, false otherwise. | [optional] 
**Price** | **string** | The price of this zone. **This is a string because this number might be too large to hold in a regular number object.** | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

