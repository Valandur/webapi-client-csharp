# IO.Swagger.Model.VillagerShopsShop
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | [**CatalogTypeEntityType**](CatalogTypeEntityType.md) | The minecraft entity type string for this shops visual entity | 
**Link** | **string** | The API link that can be used to obtain more information about this object | 
**EntityVariant** | **string** | A very dynamic variant string for vanilla mobs, most variants as in the minecraft wiki should be supported | [optional] 
**Location** | [**Location**](Location.md) | Where the shop is currently located | [optional] 
**Name** | **string** | The escaped shop name | [optional] 
**Owner** | **Guid?** | If this shop is a player shop this conatins the UUID of this shops owner. Omitting this field or setting it to null will remove the player-shop association. | [optional] 
**Rotation** | **double?** | The mobs roations around their up-axis | [optional] 
**StockContainer** | [**Location**](Location.md) | Location where a container should reside for stocking items. Omitting this field or setting it to null will remove the stock container. Having a player-shop without container is undefined behaviour! | [optional] 
**StockItems** | [**List&lt;VillagerShopsStockItem&gt;**](VillagerShopsStockItem.md) | Returns a list of all stock items currently listed. This property is read only. | [optional] 
**Uid** | **Guid?** | The unique shop identifier; this is not the mob uuid | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

