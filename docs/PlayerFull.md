# IO.Swagger.Model.PlayerFull
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of player, usually &#x60;minecraft:player&#x60; | [optional] 
**Uuid** | **string** | The unique identifier of the player. | [optional] 
**Online** | **bool?** | True if the player is currently online, false otherwise. | [optional] 
**Location** | [**Location**](Location.md) |  | [optional] 
**Name** | **string** | The name of the player. | [optional] 
**Link** | **string** | The API URL which contains detailed information about this player. | [optional] 
**_Class** | **string** | The fully qualified class name of the object representing the player. Usually &#x60;net.minecraft.entity.player.EntityPlayerMP&#x60;. | [optional] 
**Velocity** | [**Vector3**](Vector3.md) |  | [optional] 
**Rotation** | [**Vector3**](Vector3.md) |  | [optional] 
**Scale** | [**Vector3**](Vector3.md) |  | [optional] 
**Inventory** | [**Inventory**](Inventory.md) |  | [optional] 
**Connection** | [**PlayerFullConnection**](PlayerFullConnection.md) |  | [optional] 
**Armour** | [**PlayerFullArmour**](PlayerFullArmour.md) |  | [optional] 
**Achievements** | [**List&lt;PlayerFullAchievements&gt;**](PlayerFullAchievements.md) | An array of achievements the player has been awarded. | [optional] 
**Experience** | [**PlayerFullExperience**](PlayerFullExperience.md) |  | [optional] 
**GameMode** | **string** | The current game mode the player is in. | [optional] 
**Joined** | [**PlayerFullJoined**](PlayerFullJoined.md) |  | [optional] 
**Health** | [**PlayerFullHealth**](PlayerFullHealth.md) |  | [optional] 
**Food** | [**PlayerFullFood**](PlayerFullFood.md) |  | [optional] 
**Statistics** | **Object** | A map from statistics id to value, keeping track of the players actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

