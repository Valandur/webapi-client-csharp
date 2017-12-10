# IO.Swagger.Model.UpdateWorldRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the world. | [optional] 
**Seed** | **decimal?** | The seed number. A random seed is generated if not provided. | [optional] 
**Generator** | **string** | The id of the generator type to use. Check &#x60;/registry/org.spongepowered.api.world.GeneratorType&#x60;. | [optional] 
**GameMode** | **string** | The id of the game mode to use. Check &#x60;/registry/org.spongepowered.api.entity.living.player.gamemode.GameMode&#x60;. | [optional] 
**Difficulty** | **string** | The id of the difficutly to use. Check &#x60;/registry/org.spongepowered.api.world.difficulty.Difficulty&#x60;. | [optional] 
**LoadOnStartup** | **bool?** | True if the world is loaded when the server starts, false otherwise. | [optional] 
**KeepSpawnLoaded** | **bool?** | True to keep the spawn area of the world loaded, even if it is empty. | [optional] 
**AllowCommands** | **bool?** | True if executing commands is allowed in the world. | [optional] 
**UsesMapFeatures** | **bool?** | True to use map features of the generator (such as villages). | [optional] 
**Loaded** | **bool?** | True to load the world, false to unload it. | [optional] 
**GameRules** | **Object** | A map of keys to values for the game rules of the world. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

