# IO.Swagger.Api.TileEntityApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecuteTileEntityMethod**](TileEntityApi.md#executetileentitymethod) | **POST** /tile-entity/{worldUuid}/{x}/{y}/{z} | Execute tile entity methods
[**GetTileEntities**](TileEntityApi.md#gettileentities) | **GET** /tile-entity | Tile entities list
[**GetTileEntity**](TileEntityApi.md#gettileentity) | **GET** /tile-entity/{worldUuid}/{x}/{y}/{z} | Detailed tile entity info


<a name="executetileentitymethod"></a>
# **ExecuteTileEntityMethod**
> ExecuteTileEntityMethodResponse ExecuteTileEntityMethod (string worldUuid, int? x, int? y, int? z, RawRequest request)

Execute tile entity methods

Provides direct access to the underlaying tile entity object and can execute any method on it.  > Required permission: tile-entity.method 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteTileEntityMethodExample
    {
        public void main()
        {
            // Configure API key authorization: headerKey
            Configuration.Default.ApiKey.Add("x-webapi-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-webapi-key", "Bearer");
            // Configure API key authorization: queryKey
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new TileEntityApi();
            var worldUuid = worldUuid_example;  // string | The uuid of the world the tile entity is in.
            var x = 56;  // int? | The x-coordinate of the tile entity.
            var y = 56;  // int? | The y-coordinate of the tile entity.
            var z = 56;  // int? | The z-coordinate of the tile entity.
            var request = new RawRequest(); // RawRequest | Information about which method to execute.

            try
            {
                // Execute tile entity methods
                ExecuteTileEntityMethodResponse result = apiInstance.ExecuteTileEntityMethod(worldUuid, x, y, z, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TileEntityApi.ExecuteTileEntityMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **worldUuid** | **string**| The uuid of the world the tile entity is in. | 
 **x** | **int?**| The x-coordinate of the tile entity. | 
 **y** | **int?**| The y-coordinate of the tile entity. | 
 **z** | **int?**| The z-coordinate of the tile entity. | 
 **request** | [**RawRequest**](RawRequest.md)| Information about which method to execute. | 

### Return type

[**ExecuteTileEntityMethodResponse**](ExecuteTileEntityMethodResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettileentities"></a>
# **GetTileEntities**
> TileEntitiesResponse GetTileEntities (string world = null, string type = null, string limit = null)

Tile entities list

Get a list of all tile entities on the server (in all worlds, unless specified).  > Required permission: tile-entity.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTileEntitiesExample
    {
        public void main()
        {
            // Configure API key authorization: headerKey
            Configuration.Default.ApiKey.Add("x-webapi-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-webapi-key", "Bearer");
            // Configure API key authorization: queryKey
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new TileEntityApi();
            var world = world_example;  // string | The uuid of the world to filter entities by. (optional) 
            var type = type_example;  // string | The TileEntityType id to filter the tile entities by. (optional) 
            var limit = limit_example;  // string | The maximum amount of tile entities to return. (optional) 

            try
            {
                // Tile entities list
                TileEntitiesResponse result = apiInstance.GetTileEntities(world, type, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TileEntityApi.GetTileEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **world** | **string**| The uuid of the world to filter entities by. | [optional] 
 **type** | **string**| The TileEntityType id to filter the tile entities by. | [optional] 
 **limit** | **string**| The maximum amount of tile entities to return. | [optional] 

### Return type

[**TileEntitiesResponse**](TileEntitiesResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettileentity"></a>
# **GetTileEntity**
> TileEntityResponse GetTileEntity (string worldUuid, int? x, int? y, int? z, string fields = null, string methods = null)

Detailed tile entity info

Get detailed information about a tile entity.  > Required permission: tile-entity.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTileEntityExample
    {
        public void main()
        {
            // Configure API key authorization: headerKey
            Configuration.Default.ApiKey.Add("x-webapi-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-webapi-key", "Bearer");
            // Configure API key authorization: queryKey
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new TileEntityApi();
            var worldUuid = worldUuid_example;  // string | The uuid of the world the tile entity is in.
            var x = 56;  // int? | The x-coordinate of the tile entity.
            var y = 56;  // int? | The y-coordinate of the tile entity.
            var z = 56;  // int? | The z-coordinate of the tile entity.
            var fields = fields_example;  // string | An optional list of additional fields to get. (optional) 
            var methods = methods_example;  // string | An optional list of additional methods to get. (optional) 

            try
            {
                // Detailed tile entity info
                TileEntityResponse result = apiInstance.GetTileEntity(worldUuid, x, y, z, fields, methods);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TileEntityApi.GetTileEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **worldUuid** | **string**| The uuid of the world the tile entity is in. | 
 **x** | **int?**| The x-coordinate of the tile entity. | 
 **y** | **int?**| The y-coordinate of the tile entity. | 
 **z** | **int?**| The z-coordinate of the tile entity. | 
 **fields** | **string**| An optional list of additional fields to get. | [optional] 
 **methods** | **string**| An optional list of additional methods to get. | [optional] 

### Return type

[**TileEntityResponse**](TileEntityResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

