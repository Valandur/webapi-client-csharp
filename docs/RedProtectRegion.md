# IO.Swagger.Model.RedProtectRegion
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique id of this region | 
**Link** | **string** | The API link that can be used to obtain more information about this object | 
**Max** | [**Vector3d**](Vector3d.md) | The maximum coordinates that define the region | 
**Min** | [**Vector3d**](Vector3d.md) | The minimum coordinates that define the region | 
**Name** | **string** | The name of this region | 
**World** | [**World**](World.md) | The world this region is located in | 
**Admins** | [**List&lt;Player&gt;**](Player.md) | A list of players that are admins of this region | [optional] 
**CanDelete** | **bool?** | True if this region can be deleted, false otherwise | [optional] 
**Date** | **string** | The date this region was created? | [optional] 
**Flags** | **Dictionary&lt;string, Object&gt;** | A map of flags applicable to this region | [optional] 
**Leaders** | [**List&lt;Player&gt;**](Player.md) | A list of players that are leaders of this region | [optional] 
**Members** | [**List&lt;Player&gt;**](Player.md) | A list of players that are members of this region | [optional] 
**Priority** | **int?** | The priority of this region compared to other regions | [optional] 
**TpPoint** | [**Location**](Location.md) | The teleport point for this region | [optional] 
**WelcomeMessage** | **string** | The welcome message displayed to a player when they enter this region | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

