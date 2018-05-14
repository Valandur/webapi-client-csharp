# IO.Swagger.Model.Advancement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique id of the advancement | 
**Link** | **string** | The API link that can be used to obtain more information about this object | 
**Name** | **string** | The name of the advancement | 
**Title** | **string** | The title of the advancement | 
**AnnounceToChat** | **bool?** | True if the achieving of this advancement is announced in chat, false otherwise | [optional] 
**Description** | **string** | The description of the advancement | [optional] 
**Hidden** | **bool?** | True if this is a hidden advancement | [optional] 
**Parent** | [**Advancement**](Advancement.md) | The parent advancement, which must be unlocked prior to this advancement | [optional] 
**ShowToast** | **bool?** | True if achieving this advancement shows the player a toast message, false otherwise | [optional] 
**Tree** | [**CatalogTypeAdvancementTree**](CatalogTypeAdvancementTree.md) | The advancement tree that this advancement belongs to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

