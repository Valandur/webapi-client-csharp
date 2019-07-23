# IO.Swagger.Model.VillagerShopsStockItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BuyPrice** | **double?** | The amount of money this stack consts to buy as player | 
**Currency** | [**CatalogTypeCurrency**](CatalogTypeCurrency.md) | The currency for this item listing | 
**HasStock** | **bool?** | Returns wether this shop has a limited stock | 
**Item** | [**ItemStack**](ItemStack.md) | The raw ItemStack data for this shop listing | 
**MaxStock** | **int?** | If this shop has a limited stock, returns how many of these items can be stocked, 0 is unlimited | 
**SellPrice** | **double?** | The amount of money this stack earns the player when selling | 
**ShopId** | **Guid?** | The shop uuid offering this item listing | 
**Stock** | **int?** | If this shop has a limited stock, returns how many items are stocked, otherwise returns items stack size | 
**Id** | **int?** | The index of this item withing the shops inventory | [optional] 
**Link** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

