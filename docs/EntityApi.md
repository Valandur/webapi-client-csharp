# IO.Swagger.Api.EntityApi

All URIs are relative to *http://<host>/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeEntity**](EntityApi.md#changeentity) | **PUT** /entity/{uuid} | Edit entity
[**CreateEntity**](EntityApi.md#createentity) | **POST** /entity | Create an entity
[**DestroyEntity**](EntityApi.md#destroyentity) | **DELETE** /entity/{uuid} | Destroy an entity
[**ExecuteEntityMethod**](EntityApi.md#executeentitymethod) | **POST** /entity/{uuid} | Execute entity method
[**GetEntities**](EntityApi.md#getentities) | **GET** /entity | Entities list
[**GetEntity**](EntityApi.md#getentity) | **GET** /entity/{uuid} | Detailed entity info


<a name="changeentity"></a>
# **ChangeEntity**
> EntityResponse ChangeEntity (string uuid, UpdateEntityRequest updateEntityRequest)

Edit entity

Update the properties of an existing entity.  > Required permission: entity.change 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeEntityExample
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

            var apiInstance = new EntityApi();
            var uuid = uuid_example;  // string | The uuid of the entity.
            var updateEntityRequest = new UpdateEntityRequest(); // UpdateEntityRequest | The new properties of the entity

            try
            {
                // Edit entity
                EntityResponse result = apiInstance.ChangeEntity(uuid, updateEntityRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntityApi.ChangeEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the entity. | 
 **updateEntityRequest** | [**UpdateEntityRequest**](UpdateEntityRequest.md)| The new properties of the entity | 

### Return type

[**EntityResponse**](EntityResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createentity"></a>
# **CreateEntity**
> EntityResponse CreateEntity (CreateEntityRequest createEntityRequest)

Create an entity

Creates & Spawns a new entity with the specified properties.  > Required permission: entity.create 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateEntityExample
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

            var apiInstance = new EntityApi();
            var createEntityRequest = new CreateEntityRequest(); // CreateEntityRequest | 

            try
            {
                // Create an entity
                EntityResponse result = apiInstance.CreateEntity(createEntityRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntityApi.CreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createEntityRequest** | [**CreateEntityRequest**](CreateEntityRequest.md)|  | 

### Return type

[**EntityResponse**](EntityResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destroyentity"></a>
# **DestroyEntity**
> EntityResponse DestroyEntity (string uuid)

Destroy an entity

Destroys an entity.  > Required permission: entity.delete 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DestroyEntityExample
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

            var apiInstance = new EntityApi();
            var uuid = uuid_example;  // string | The uuid of the entity.

            try
            {
                // Destroy an entity
                EntityResponse result = apiInstance.DestroyEntity(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntityApi.DestroyEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the entity. | 

### Return type

[**EntityResponse**](EntityResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeentitymethod"></a>
# **ExecuteEntityMethod**
> EntityMethodResult ExecuteEntityMethod (string uuid, RawRequest request)

Execute entity method

Provides direct access to the underlaying entity object and can execute any method on it.  > Required permission: entity.method 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteEntityMethodExample
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

            var apiInstance = new EntityApi();
            var uuid = uuid_example;  // string | The uuid of the entity.
            var request = new RawRequest(); // RawRequest | Information about which method to execute.

            try
            {
                // Execute entity method
                EntityMethodResult result = apiInstance.ExecuteEntityMethod(uuid, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntityApi.ExecuteEntityMethod: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the entity. | 
 **request** | [**RawRequest**](RawRequest.md)| Information about which method to execute. | 

### Return type

[**EntityMethodResult**](EntityMethodResult.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentities"></a>
# **GetEntities**
> EntitiesList GetEntities (string details = null)

Entities list

Get a list of all entities on the server (in all worlds).  > Required permission: entity.list 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntitiesExample
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

            var apiInstance = new EntityApi();
            var details = details_example;  // string | Pass this parameter to receive the full details for each entity. (optional) 

            try
            {
                // Entities list
                EntitiesList result = apiInstance.GetEntities(details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntityApi.GetEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **details** | **string**| Pass this parameter to receive the full details for each entity. | [optional] 

### Return type

[**EntitiesList**](EntitiesList.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentity"></a>
# **GetEntity**
> EntityResponse GetEntity (string uuid, string fields = null, string methods = null)

Detailed entity info

Get detailed information about an entity.  > Required permission: entity.one 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEntityExample
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

            var apiInstance = new EntityApi();
            var uuid = uuid_example;  // string | The uuid of the entity to get detailed information about.
            var fields = fields_example;  // string | An optional list of additional fields to get. (optional) 
            var methods = methods_example;  // string | An optional list of additional methods to get. (optional) 

            try
            {
                // Detailed entity info
                EntityResponse result = apiInstance.GetEntity(uuid, fields, methods);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntityApi.GetEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| The uuid of the entity to get detailed information about. | 
 **fields** | **string**| An optional list of additional fields to get. | [optional] 
 **methods** | **string**| An optional list of additional methods to get. | [optional] 

### Return type

[**EntityResponse**](EntityResponse.md)

### Authorization

[headerKey](../README.md#headerKey), [queryKey](../README.md#queryKey)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

