# IO.Swagger.Model.UpdatePlayerRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**World** | **string** | The UUID or name of the world that the player is moved to. | [optional] 
**Position** | [**Vector3**](Vector3.md) |  | [optional] 
**Velocity** | [**Vector3**](Vector3.md) |  | [optional] 
**Rotation** | [**Vector3**](Vector3.md) |  | [optional] 
**Scale** | [**Vector3**](Vector3.md) |  | [optional] 
**FoodLevel** | **decimal?** | The new food level of the player. | [optional] 
**Exhaustion** | **double?** | The new exhaustion level of the player. | [optional] 
**Saturation** | **double?** | The new saturation level of the player. | [optional] 
**TotalExperience** | **decimal?** | The total amount of experience the player has. This implicitly also sets the level. | [optional] 
**Level** | **decimal?** | The current level of the player. This is also defined by the total amount of experience the player has. | [optional] 
**ExperienceSinceLevel** | **decimal?** | The amount of experience since the last level up that the player has collected. | [optional] 
**Health** | **double?** | The current amount of health the player has. | [optional] 
**MaxHealth** | **double?** | The total amount of health the player can have at maximum. | [optional] 
**Damage** | [**DamageRequest1**](DamageRequest1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

