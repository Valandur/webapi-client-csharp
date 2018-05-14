# IO.Swagger.Api.TileEntityApi

All URIs are relative to *https://localhost/api/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecuteMethod**](TileEntityApi.md#executemethod) | **POST** /tile-entity/{world}/{x}/{y}/{z}/method | Execute a method
[**GetTileEntity**](TileEntityApi.md#gettileentity) | **GET** /tile-entity/{world}/{x}/{y}/{z} | Get tile entity
[**ListTileEntities**](TileEntityApi.md#listtileentities) | **GET** /tile-entity | List tile entities


<a name="executemethod"></a>
# **ExecuteMethod**
> ExecuteMethodResponse ExecuteMethod (string world, int? x, int? y, int? z, ExecuteMethodRequest body = null, bool? details = null, string accept = null, bool? pretty = null)

Execute a method

Provides direct access to the underlaying tile entity object and can execute any method on it.     **Required permissions:**    - **tile-entity.method**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteMethodExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.AddApiKey("X-WebAPI-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-WebAPI-Key", "Bearer");
            // Configure API key authorization: ApiKeyQuery
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new TileEntityApi();
            var world = world_example;  // string | The world the tile entity is in
            var x = 56;  // int? | The x-coordinate of the tile-entity
            var y = 56;  // int? | The x-coordinate of the tile-entity
            var z = 56;  // int? | The x-coordinate of the tile-entity
            var body = new ExecuteMethodRequest(); // ExecuteMethodRequest |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Execute a method
                ExecuteMethodResponse result = apiInstance.ExecuteMethod(world, x, y, z, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TileEntityApi.ExecuteMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **world** | **string**| The world the tile entity is in | 
 **x** | **int?**| The x-coordinate of the tile-entity | 
 **y** | **int?**| The x-coordinate of the tile-entity | 
 **z** | **int?**| The x-coordinate of the tile-entity | 
 **body** | [**ExecuteMethodRequest**](ExecuteMethodRequest.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**ExecuteMethodResponse**](ExecuteMethodResponse.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettileentity"></a>
# **GetTileEntity**
> TileEntity GetTileEntity (string world, int? x, int? y, int? z, bool? details = null, string accept = null, bool? pretty = null)

Get tile entity

Get detailed information about a tile entity.     **Required permissions:**    - **tile-entity.one**   

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
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.AddApiKey("X-WebAPI-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-WebAPI-Key", "Bearer");
            // Configure API key authorization: ApiKeyQuery
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new TileEntityApi();
            var world = world_example;  // string | The world the tile entity is in
            var x = 56;  // int? | The x-coordinate of the tile-entity
            var y = 56;  // int? | The y-coordinate of the tile-entity
            var z = 56;  // int? | The z-coordinate of the tile-entity
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get tile entity
                TileEntity result = apiInstance.GetTileEntity(world, x, y, z, details, accept, pretty);
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
 **world** | **string**| The world the tile entity is in | 
 **x** | **int?**| The x-coordinate of the tile-entity | 
 **y** | **int?**| The y-coordinate of the tile-entity | 
 **z** | **int?**| The z-coordinate of the tile-entity | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**TileEntity**](TileEntity.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtileentities"></a>
# **ListTileEntities**
> List<TileEntity> ListTileEntities (string world = null, string type = null, string min = null, string max = null, int? limit = null, bool? details = null, string accept = null, bool? pretty = null)

List tile entities

Get a list of all tile entities on the server (in all worlds, unless specified).     **Required permissions:**    - **tile-entity.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTileEntitiesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.AddApiKey("X-WebAPI-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-WebAPI-Key", "Bearer");
            // Configure API key authorization: ApiKeyQuery
            Configuration.Default.AddApiKey("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("key", "Bearer");

            var apiInstance = new TileEntityApi();
            var world = world_example;  // string | The world to filter tile entities by (optional) 
            var type = type_example;  // string | The type if of tile entities to filter by (optional) 
            var min = min_example;  // string | The minimum coordinates at which the tile entity must be, min=x|y|z (optional) 
            var max = max_example;  // string | The maximum coordinates at which the tile entity must be, max=x|y|z (optional) 
            var limit = 56;  // int? | The maximum amount of tile entities returned (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List tile entities
                List&lt;TileEntity&gt; result = apiInstance.ListTileEntities(world, type, min, max, limit, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TileEntityApi.ListTileEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **world** | **string**| The world to filter tile entities by | [optional] 
 **type** | **string**| The type if of tile entities to filter by | [optional] 
 **min** | **string**| The minimum coordinates at which the tile entity must be, min&#x3D;x|y|z | [optional] 
 **max** | **string**| The maximum coordinates at which the tile entity must be, max&#x3D;x|y|z | [optional] 
 **limit** | **int?**| The maximum amount of tile entities returned | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**List<TileEntity>**](TileEntity.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

