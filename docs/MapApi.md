# IO.Swagger.Api.MapApi

All URIs are relative to *https://localhost/api/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMap**](MapApi.md#getmap) | **GET** /map/{world}/{x}/{z} | Get a map tile


<a name="getmap"></a>
# **GetMap**
> void GetMap (string world, int? x, int? z, bool? details = null, string accept = null, bool? pretty = null)

Get a map tile

Returns an image representing the biomes of the blocks within the specified tile     **Required permissions:**    - **map.map**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMapExample
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

            var apiInstance = new MapApi();
            var world = world_example;  // string | The world to get the map tile from
            var x = 56;  // int? | The x-coordinate of the tile (is multiplied by the TILE_SIZE)
            var z = 56;  // int? | The z-coordinate of the tile (is multiplied by the TILE_SIZE)
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a map tile
                apiInstance.GetMap(world, x, z, details, accept, pretty);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MapApi.GetMap: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **world** | **string**| The world to get the map tile from | 
 **x** | **int?**| The x-coordinate of the tile (is multiplied by the TILE_SIZE) | 
 **z** | **int?**| The z-coordinate of the tile (is multiplied by the TILE_SIZE) | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

