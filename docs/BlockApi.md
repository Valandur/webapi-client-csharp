# IO.Swagger.Api.BlockApi

All URIs are relative to *https://localhost/api/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBlockOperation**](BlockApi.md#createblockoperation) | **POST** /block/op | Create a block operation
[**DeleteBlockOperation**](BlockApi.md#deleteblockoperation) | **DELETE** /block/op/{uuid} | Stop a block operation
[**GetBlock**](BlockApi.md#getblock) | **GET** /block/{world}/{x}/{y}/{z} | Get a block
[**GetBlockOperation**](BlockApi.md#getblockoperation) | **GET** /block/op/{uuid} | Get a block operation
[**ListBlockOperations**](BlockApi.md#listblockoperations) | **GET** /block/op | List block operations
[**ModifyBlockOperation**](BlockApi.md#modifyblockoperation) | **PUT** /block/op/{uuid} | Modify a block operation


<a name="createblockoperation"></a>
# **CreateBlockOperation**
> BlockOperation CreateBlockOperation (CreateBlockOperationRequest body = null, bool? details = null, string accept = null, bool? pretty = null)

Create a block operation

Start a request to get or change blocks on the server.     **Required permissions:**    - **block.op.create**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBlockOperationExample
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

            var apiInstance = new BlockApi();
            var body = new CreateBlockOperationRequest(); // CreateBlockOperationRequest |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Create a block operation
                BlockOperation result = apiInstance.CreateBlockOperation(body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.CreateBlockOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateBlockOperationRequest**](CreateBlockOperationRequest.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**BlockOperation**](BlockOperation.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteblockoperation"></a>
# **DeleteBlockOperation**
> BlockOperation DeleteBlockOperation (Guid? uuid, bool? details = null, string accept = null, bool? pretty = null)

Stop a block operation

Cancel a pending or running block operation. **THIS DOES NOT UNDO THE BLOCK CHANGES**     **Required permissions:**    - **block.op.delete**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBlockOperationExample
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

            var apiInstance = new BlockApi();
            var uuid = new Guid?(); // Guid? | The uuid of the block operation
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Stop a block operation
                BlockOperation result = apiInstance.DeleteBlockOperation(uuid, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.DeleteBlockOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The uuid of the block operation | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**BlockOperation**](BlockOperation.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblock"></a>
# **GetBlock**
> BlockState GetBlock (string world, int? x, int? y, int? z, bool? details = null, string accept = null, bool? pretty = null)

Get a block

Gets information about one block in the world.     **Required permissions:**    - **block.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBlockExample
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

            var apiInstance = new BlockApi();
            var world = world_example;  // string | The uuid of the world to get the block from
            var x = 56;  // int? | The x-coordinate of the block
            var y = 56;  // int? | The y-coordinate of the block
            var z = 56;  // int? | The z-coordinate of the block
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a block
                BlockState result = apiInstance.GetBlock(world, x, y, z, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.GetBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **world** | **string**| The uuid of the world to get the block from | 
 **x** | **int?**| The x-coordinate of the block | 
 **y** | **int?**| The y-coordinate of the block | 
 **z** | **int?**| The z-coordinate of the block | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**BlockState**](BlockState.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblockoperation"></a>
# **GetBlockOperation**
> BlockOperation GetBlockOperation (Guid? uuid, bool? details = null, string accept = null, bool? pretty = null)

Get a block operation

Gets details about a specific block operation     **Required permissions:**    - **block.op.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBlockOperationExample
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

            var apiInstance = new BlockApi();
            var uuid = new Guid?(); // Guid? | The uuid of the block operation
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a block operation
                BlockOperation result = apiInstance.GetBlockOperation(uuid, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.GetBlockOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The uuid of the block operation | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**BlockOperation**](BlockOperation.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listblockoperations"></a>
# **ListBlockOperations**
> List<BlockOperation> ListBlockOperations (bool? details = null, string accept = null, bool? pretty = null)

List block operations

Returns a list of all the currently running block operations.     **Required permissions:**    - **block.op.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListBlockOperationsExample
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

            var apiInstance = new BlockApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List block operations
                List&lt;BlockOperation&gt; result = apiInstance.ListBlockOperations(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.ListBlockOperations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**List<BlockOperation>**](BlockOperation.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="modifyblockoperation"></a>
# **ModifyBlockOperation**
> BlockOperation ModifyBlockOperation (Guid? uuid, ModifyBlockOperationRequest body = null, bool? details = null, string accept = null, bool? pretty = null)

Modify a block operation

Modify an existing block operation to either pause or continue it.     **Required permissions:**    - **block.op.modify**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ModifyBlockOperationExample
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

            var apiInstance = new BlockApi();
            var uuid = new Guid?(); // Guid? | The uuid of the block operation
            var body = new ModifyBlockOperationRequest(); // ModifyBlockOperationRequest |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Modify a block operation
                BlockOperation result = apiInstance.ModifyBlockOperation(uuid, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.ModifyBlockOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The uuid of the block operation | 
 **body** | [**ModifyBlockOperationRequest**](ModifyBlockOperationRequest.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**BlockOperation**](BlockOperation.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

