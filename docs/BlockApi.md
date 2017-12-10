# IO.Swagger.Api.BlockApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelBlockOperation**](BlockApi.md#cancelblockoperation) | **DELETE** /block/op/{uuid} | Cancel block operation
[**ChangeBlockOperation**](BlockApi.md#changeblockoperation) | **PUT** /block/op/{uuid} | Modify block operation
[**GetBlock**](BlockApi.md#getblock) | **GET** /block/{world}/{x}/{y}/{z} | Get one block
[**GetBlockOperation**](BlockApi.md#getblockoperation) | **GET** /block/op/{uuid} | Block operation details
[**GetBlockOperations**](BlockApi.md#getblockoperations) | **GET** /block/op | List block operations
[**StartBlockOperation**](BlockApi.md#startblockoperation) | **POST** /block/op | Create block operation


<a name="cancelblockoperation"></a>
# **CancelBlockOperation**
> BlockOperationResponse CancelBlockOperation (string uuid)

Cancel block operation

Cancel a pending or running block operation. **THIS DOES NOT UNDO THE BLOCK CHANGES**  > Required permission: block.op.delete 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelBlockOperationExample
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

            var apiInstance = new BlockApi();
            var uuid = uuid_example;  // string | The uuid of the block operation.

            try
            {
                // Cancel block operation
                BlockOperationResponse result = apiInstance.CancelBlockOperation(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.CancelBlockOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the block operation. | 

### Return type

[**BlockOperationResponse**](BlockOperationResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeblockoperation"></a>
# **ChangeBlockOperation**
> BlockOperationResponse ChangeBlockOperation (string uuid, Data data)

Modify block operation

Modify an existing block operation to either pause or continue it.  > Required permission: block.op.change 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeBlockOperationExample
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

            var apiInstance = new BlockApi();
            var uuid = uuid_example;  // string | The uuid of the block operation.
            var data = new Data(); // Data | The new data applied to the block operation.

            try
            {
                // Modify block operation
                BlockOperationResponse result = apiInstance.ChangeBlockOperation(uuid, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.ChangeBlockOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the block operation. | 
 **data** | [**Data**](Data.md)| The new data applied to the block operation. | 

### Return type

[**BlockOperationResponse**](BlockOperationResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblock"></a>
# **GetBlock**
> SingleBlock GetBlock (string world, int? x, int? y, int? z)

Get one block

Gets information about one block in the world.  > Required permission: block.one 

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
            // Configure API key authorization: headerKey
            Configuration.Default.ApiKey.Add("x-webapi-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-webapi-key", "Bearer");
            // Configure API key authorization: queryKey
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new BlockApi();
            var world = world_example;  // string | The uuid of the world the block is in.
            var x = 56;  // int? | The x-coordinate of the block.
            var y = 56;  // int? | The y-coordinate of the block.
            var z = 56;  // int? | The z-coordinate of the block.

            try
            {
                // Get one block
                SingleBlock result = apiInstance.GetBlock(world, x, y, z);
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
 **world** | **string**| The uuid of the world the block is in. | 
 **x** | **int?**| The x-coordinate of the block. | 
 **y** | **int?**| The y-coordinate of the block. | 
 **z** | **int?**| The z-coordinate of the block. | 

### Return type

[**SingleBlock**](SingleBlock.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblockoperation"></a>
# **GetBlockOperation**
> BlockOperationResponse GetBlockOperation (string uuid)

Block operation details

Gets details about a specific block operation  > Required permission: block.op.one 

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
            // Configure API key authorization: headerKey
            Configuration.Default.ApiKey.Add("x-webapi-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-webapi-key", "Bearer");
            // Configure API key authorization: queryKey
            Configuration.Default.ApiKey.Add("key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("key", "Bearer");

            var apiInstance = new BlockApi();
            var uuid = uuid_example;  // string | The uuid of the block operation.

            try
            {
                // Block operation details
                BlockOperationResponse result = apiInstance.GetBlockOperation(uuid);
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
 **uuid** | **string**| The uuid of the block operation. | 

### Return type

[**BlockOperationResponse**](BlockOperationResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblockoperations"></a>
# **GetBlockOperations**
> BlockOperationsList GetBlockOperations ()

List block operations

Returns a list of all the currently running block operations.  > Required permission: block.op.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBlockOperationsExample
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

            var apiInstance = new BlockApi();

            try
            {
                // List block operations
                BlockOperationsList result = apiInstance.GetBlockOperations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.GetBlockOperations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BlockOperationsList**](BlockOperationsList.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="startblockoperation"></a>
# **StartBlockOperation**
> BlockOperationResponse StartBlockOperation (List<BlockOperationNew> request)

Create block operation

Start a request to get or change blocks on the server.  > Required permission: block.op.create 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StartBlockOperationExample
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

            var apiInstance = new BlockApi();
            var request = new List<BlockOperationNew>(); // List<BlockOperationNew> | The requested changes to blocks

            try
            {
                // Create block operation
                BlockOperationResponse result = apiInstance.StartBlockOperation(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BlockApi.StartBlockOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**List&lt;BlockOperationNew&gt;**](BlockOperationNew.md)| The requested changes to blocks | 

### Return type

[**BlockOperationResponse**](BlockOperationResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

