# IO.Swagger.Model.MobSpawnerData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaximumNearbyEntities** | **int?** | The maximum number of nearby entities for another mob to spawn | 
**MaximumSpawnDelay** | **int?** | The maximum delay between two consecutive spawns | 
**MinimumSpawnDelay** | **int?** | The minimum delay between two consecutive spawns | 
**NextEntityToSpawn** | [**EntityArchtype**](EntityArchtype.md) | The next entity type that will be spawned by this spawner | 
**PossibleEntitiesToSpawn** | [**List&lt;TableEntryEntityArchetype&gt;**](TableEntryEntityArchetype.md) | A weighted table of probability for each entity type to spawn | 
**RemainingDelay** | **int?** | The remaining time until the next spawn attempt | 
**RequiredPlayerRange** | **int?** | The block range within there must be a player to trigger the spawn | 
**SpawnCount** | **int?** | The amount of entities that will spawn in one attempt | 
**SpawnRange** | **int?** | The range from the spawner within which the entities will spawn | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

