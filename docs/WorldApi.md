# IO.Swagger.Api.WorldApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeWorld**](WorldApi.md#changeworld) | **PUT** /world/{uuid} | Edit world
[**CreateWorld**](WorldApi.md#createworld) | **POST** /world | Create a world
[**DeleteWorld**](WorldApi.md#deleteworld) | **DELETE** /world/{uuid} | Delete a world
[**ExecuteWorldMethod**](WorldApi.md#executeworldmethod) | **POST** /world/{uuid} | Execute world methods
[**GetChunk**](WorldApi.md#getchunk) | **GET** /world/{uuid}/chunk/{x}/{z} | Detailed chunk info
[**GetChunks**](WorldApi.md#getchunks) | **GET** /world/{uuid}/chunk | Loaded chunk list
[**GetWorld**](WorldApi.md#getworld) | **GET** /world/{uuid} | Detailed world info
[**GetWorlds**](WorldApi.md#getworlds) | **GET** /world | World list


<a name="changeworld"></a>
# **ChangeWorld**
> WorldResponse ChangeWorld (string uuid, UpdateWorldRequest updateWorldRequest)

Edit world

Update the properties of an existing world.  > Required permission: world.change 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeWorldExample
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

            var apiInstance = new WorldApi();
            var uuid = uuid_example;  // string | The uuid of the world.
            var updateWorldRequest = new UpdateWorldRequest(); // UpdateWorldRequest | The new properties of the world

            try
            {
                // Edit world
                WorldResponse result = apiInstance.ChangeWorld(uuid, updateWorldRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldApi.ChangeWorld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the world. | 
 **updateWorldRequest** | [**UpdateWorldRequest**](UpdateWorldRequest.md)| The new properties of the world | 

### Return type

[**WorldResponse**](WorldResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createworld"></a>
# **CreateWorld**
> WorldResponse CreateWorld (CreateWorldRequest createWorldRequest)

Create a world

Creates a new world with the specified settings. This does not yet load the world.  > Required permission: world.create 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateWorldExample
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

            var apiInstance = new WorldApi();
            var createWorldRequest = new CreateWorldRequest(); // CreateWorldRequest | 

            try
            {
                // Create a world
                WorldResponse result = apiInstance.CreateWorld(createWorldRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldApi.CreateWorld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createWorldRequest** | [**CreateWorldRequest**](CreateWorldRequest.md)|  | 

### Return type

[**WorldResponse**](WorldResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworld"></a>
# **DeleteWorld**
> WorldResponse DeleteWorld (string uuid)

Delete a world

Deletes an existing world. **The world must be unloaded before deleting it**  > Required permission: world.delete 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteWorldExample
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

            var apiInstance = new WorldApi();
            var uuid = uuid_example;  // string | The uuid of the world.

            try
            {
                // Delete a world
                WorldResponse result = apiInstance.DeleteWorld(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldApi.DeleteWorld: " + e.Message );
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

[**WorldResponse**](WorldResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeworldmethod"></a>
# **ExecuteWorldMethod**
> ExecuteWorldMethodResponse ExecuteWorldMethod (string uuid, RawRequest request)

Execute world methods

Provides direct access to the underlaying world object and can execute any method on it.  > Required permission: world.method 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteWorldMethodExample
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

            var apiInstance = new WorldApi();
            var uuid = uuid_example;  // string | The uuid of the world.
            var request = new RawRequest(); // RawRequest | Information about which method to execute.

            try
            {
                // Execute world methods
                ExecuteWorldMethodResponse result = apiInstance.ExecuteWorldMethod(uuid, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldApi.ExecuteWorldMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the world. | 
 **request** | [**RawRequest**](RawRequest.md)| Information about which method to execute. | 

### Return type

[**ExecuteWorldMethodResponse**](ExecuteWorldMethodResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

            var apiInstance = new WorldApi();
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
                Debug.Print("Exception when calling WorldApi.GetChunk: " + e.Message );
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

            var apiInstance = new WorldApi();
            var uuid = uuid_example;  // string | The uuid of the world.

            try
            {
                // Loaded chunk list
                ChunksResponse result = apiInstance.GetChunks(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldApi.GetChunks: " + e.Message );
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

<a name="getworld"></a>
# **GetWorld**
> WorldResponse GetWorld (string uuid, string fields = null, string methods = null)

Detailed world info

Get detailed information about a world.  > Required permission: world.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWorldExample
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

            var apiInstance = new WorldApi();
            var uuid = uuid_example;  // string | The uuid of the world to get detailed information about.
            var fields = fields_example;  // string | An optional list of additional fields to get. (optional) 
            var methods = methods_example;  // string | An optional list of additional methods to get. (optional) 

            try
            {
                // Detailed world info
                WorldResponse result = apiInstance.GetWorld(uuid, fields, methods);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorld: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the world to get detailed information about. | 
 **fields** | **string**| An optional list of additional fields to get. | [optional] 
 **methods** | **string**| An optional list of additional methods to get. | [optional] 

### Return type

[**WorldResponse**](WorldResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworlds"></a>
# **GetWorlds**
> WorldsResponse GetWorlds (string details = null)

World list

Get a list of all the worlds on the server.  > Required permission: world.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWorldsExample
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

            var apiInstance = new WorldApi();
            var details = details_example;  // string | Pass this parameter to receive the full details for each world. (optional) 

            try
            {
                // World list
                WorldsResponse result = apiInstance.GetWorlds(details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorldApi.GetWorlds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **details** | **string**| Pass this parameter to receive the full details for each world. | [optional] 

### Return type

[**WorldsResponse**](WorldsResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

