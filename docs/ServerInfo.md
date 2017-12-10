# IO.Swagger.Model.ServerInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Motd** | **string** | The message of the day set on the server. | [optional] 
**Players** | **decimal?** | The amount of players currently playing on the server | [optional] 
**MaxPlayers** | **decimal?** | The maximum amount of players allowed on the server | [optional] 
**UptimeTicks** | **decimal?** | The number of ticks the server has been running | [optional] 
**Tps** | **decimal?** | The average ticks per second the server is running with. 20 is ideal. | [optional] 
**HasWhitelist** | **bool?** | True if the server has a whitelist, false otherwise. | [optional] 
**MinecraftVersion** | **string** | The minecraft version running on the server. | [optional] 
**Game** | [**ServerInfoDetail**](ServerInfoDetail.md) |  | [optional] 
**Api** | [**ServerInfoDetail**](ServerInfoDetail.md) |  | [optional] 
**Implementation** | [**ServerInfoDetail**](ServerInfoDetail.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

