# IO.Swagger.Api.ChunkApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChunk**](ChunkApi.md#getchunk) | **GET** /world/{uuid}/chunk/{x}/{z} | Detailed chunk info
[**GetChunks**](ChunkApi.md#getchunks) | **GET** /world/{uuid}/chunk | Loaded chunk list


<a name="getchunk"></a>
# **GetChunk**
> ChunkResponse GetChunk (string uuid, int? x, int? z)

Detailed chunk info

Get detailed information about a chunk  > Required permission: world.chunk.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChunkExample
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

            var apiInstance = new ChunkApi();
            var uuid = uuid_example;  // string | The uuid of the world.
            var x = 56;  // int? | The x-coordinate of the chunk.
            var z = 56;  // int? | The z-coordinate of the chunk.

            try
            {
                // Detailed chunk info
                ChunkResponse result = apiInstance.GetChunk(uuid, x, z);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChunkApi.GetChunk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the world. | 
 **x** | **int?**| The x-coordinate of the chunk. | 
 **z** | **int?**| The z-coordinate of the chunk. | 

### Return type

[**ChunkResponse**](ChunkResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchunks"></a>
# **GetChunks**
> ChunksResponse GetChunks (string uuid)

Loaded chunk list

Gets a list of all the loaded chunks for the specified world.  > Required permission: world.chunk.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetChunksExample
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

            var apiInstance = new ChunkApi();
            var uuid = uuid_example;  // string | The uuid of the world.

            try
            {
                // Loaded chunk list
                ChunksResponse result = apiInstance.GetChunks(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChunkApi.GetChunks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the world. | 

### Return type

[**ChunksResponse**](ChunksResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

