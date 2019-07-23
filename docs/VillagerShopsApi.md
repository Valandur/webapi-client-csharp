# IO.Swagger.Api.VillagerShopsApi

All URIs are relative to *https://localhost/api/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddShopItem**](VillagerShopsApi.md#addshopitem) | **POST** /vshop/shop/{id}/item | Add Shop Item
[**AddShopItem_0**](VillagerShopsApi.md#addshopitem_0) | **POST** /vshop/shop/{id}/item | Add Shop Item
[**CreateShop**](VillagerShopsApi.md#createshop) | **POST** /vshop/shop | Create Shops
[**CreateShop_0**](VillagerShopsApi.md#createshop_0) | **POST** /vshop/shop | Create Shops
[**DeleteShop**](VillagerShopsApi.md#deleteshop) | **DELETE** /vshop/shop/{id} | Delete a Shop
[**DeleteShopItem**](VillagerShopsApi.md#deleteshopitem) | **DELETE** /vshop/shop/{id}/item/{item} | Removes a Shop Item
[**DeleteShopItem_0**](VillagerShopsApi.md#deleteshopitem_0) | **DELETE** /vshop/shop/{id}/item/{item} | Removes a Shop Item
[**DeleteShop_0**](VillagerShopsApi.md#deleteshop_0) | **DELETE** /vshop/shop/{id} | Delete a Shop
[**GetShop**](VillagerShopsApi.md#getshop) | **GET** /vshop/shop/{id} | Get a Shop
[**GetShopItem**](VillagerShopsApi.md#getshopitem) | **GET** /vshop/shop/{id}/item/{item} | Get a Shop
[**GetShopItem_0**](VillagerShopsApi.md#getshopitem_0) | **GET** /vshop/shop/{id}/item/{item} | Get a Shop
[**GetShop_0**](VillagerShopsApi.md#getshop_0) | **GET** /vshop/shop/{id} | Get a Shop
[**ListShopItems**](VillagerShopsApi.md#listshopitems) | **GET** /vshop/shop/{id}/item | List Shop Items
[**ListShopItems_0**](VillagerShopsApi.md#listshopitems_0) | **GET** /vshop/shop/{id}/item | List Shop Items
[**ListShops**](VillagerShopsApi.md#listshops) | **GET** /vshop/shop | List Shops
[**ListShops_0**](VillagerShopsApi.md#listshops_0) | **GET** /vshop/shop | List Shops
[**UpdateShop**](VillagerShopsApi.md#updateshop) | **PUT** /vshop/shop/{id} | Change Shop
[**UpdateShopItem**](VillagerShopsApi.md#updateshopitem) | **PUT** /vshop/shop/{id}/item/{item} | Change Shop Item
[**UpdateShopItem_0**](VillagerShopsApi.md#updateshopitem_0) | **PUT** /vshop/shop/{id}/item/{item} | Change Shop Item
[**UpdateShop_0**](VillagerShopsApi.md#updateshop_0) | **PUT** /vshop/shop/{id} | Change Shop


<a name="addshopitem"></a>
# **AddShopItem**
> VillagerShopsStockItem AddShopItem (Guid? id, VillagerShopsStockItem body = null, bool? details = null, string accept = null, bool? pretty = null)

Add Shop Item

Add a item to the shops listing     **Required permissions:**    - **vshop.vshop.item.create**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddShopItemExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var body = new VillagerShopsStockItem(); // VillagerShopsStockItem |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Add Shop Item
                VillagerShopsStockItem result = apiInstance.AddShopItem(id, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.AddShopItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **body** | [**VillagerShopsStockItem**](VillagerShopsStockItem.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsStockItem**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addshopitem_0"></a>
# **AddShopItem_0**
> VillagerShopsStockItem AddShopItem_0 (Guid? id, VillagerShopsStockItem body = null, bool? details = null, string accept = null, bool? pretty = null)

Add Shop Item

Add a item to the shops listing     **Required permissions:**    - **vshop.vshop.item.create**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddShopItem_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var body = new VillagerShopsStockItem(); // VillagerShopsStockItem |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Add Shop Item
                VillagerShopsStockItem result = apiInstance.AddShopItem_0(id, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.AddShopItem_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **body** | [**VillagerShopsStockItem**](VillagerShopsStockItem.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsStockItem**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createshop"></a>
# **CreateShop**
> VillagerShopsShop CreateShop (VillagerShopsShop body = null, bool? details = null, string accept = null, bool? pretty = null)

Create Shops

Spawn a new shop with base values; Some values are only set by update     **Required permissions:**    - **vshop.vshop.create**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateShopExample
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

            var apiInstance = new VillagerShopsApi();
            var body = new VillagerShopsShop(); // VillagerShopsShop |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Create Shops
                VillagerShopsShop result = apiInstance.CreateShop(body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.CreateShop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VillagerShopsShop**](VillagerShopsShop.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createshop_0"></a>
# **CreateShop_0**
> VillagerShopsShop CreateShop_0 (VillagerShopsShop body = null, bool? details = null, string accept = null, bool? pretty = null)

Create Shops

Spawn a new shop with base values; Some values are only set by update     **Required permissions:**    - **vshop.vshop.create**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateShop_0Example
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

            var apiInstance = new VillagerShopsApi();
            var body = new VillagerShopsShop(); // VillagerShopsShop |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Create Shops
                VillagerShopsShop result = apiInstance.CreateShop_0(body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.CreateShop_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VillagerShopsShop**](VillagerShopsShop.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshop"></a>
# **DeleteShop**
> VillagerShopsShop DeleteShop (Guid? id, bool? details = null, string accept = null, bool? pretty = null)

Delete a Shop

Permanently delete a shop from the server     **Required permissions:**    - **vshop.vshop.delete**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShopExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Delete a Shop
                VillagerShopsShop result = apiInstance.DeleteShop(id, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.DeleteShop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshopitem"></a>
# **DeleteShopItem**
> VillagerShopsShop DeleteShopItem (Guid? id, int? item, bool? details = null, string accept = null, bool? pretty = null)

Removes a Shop Item

Remove an item from this shop     **Required permissions:**    - **vshop.vshop.item.delete**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShopItemExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var item = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Removes a Shop Item
                VillagerShopsShop result = apiInstance.DeleteShopItem(id, item, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.DeleteShopItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **item** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshopitem_0"></a>
# **DeleteShopItem_0**
> VillagerShopsShop DeleteShopItem_0 (Guid? id, int? item, bool? details = null, string accept = null, bool? pretty = null)

Removes a Shop Item

Remove an item from this shop     **Required permissions:**    - **vshop.vshop.item.delete**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShopItem_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var item = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Removes a Shop Item
                VillagerShopsShop result = apiInstance.DeleteShopItem_0(id, item, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.DeleteShopItem_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **item** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteshop_0"></a>
# **DeleteShop_0**
> VillagerShopsShop DeleteShop_0 (Guid? id, bool? details = null, string accept = null, bool? pretty = null)

Delete a Shop

Permanently delete a shop from the server     **Required permissions:**    - **vshop.vshop.delete**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteShop_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Delete a Shop
                VillagerShopsShop result = apiInstance.DeleteShop_0(id, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.DeleteShop_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshop"></a>
# **GetShop**
> VillagerShopsShop GetShop (Guid? id, bool? details = null, string accept = null, bool? pretty = null)

Get a Shop

Get detailed information about a shop     **Required permissions:**    - **vshop.vshop.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShopExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a Shop
                VillagerShopsShop result = apiInstance.GetShop(id, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.GetShop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshopitem"></a>
# **GetShopItem**
> VillagerShopsStockItem GetShopItem (Guid? id, int? item, bool? details = null, string accept = null, bool? pretty = null)

Get a Shop

Get detailed information about a shop item     **Required permissions:**    - **vshop.vshop.item.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShopItemExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var item = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a Shop
                VillagerShopsStockItem result = apiInstance.GetShopItem(id, item, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.GetShopItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **item** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsStockItem**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshopitem_0"></a>
# **GetShopItem_0**
> VillagerShopsStockItem GetShopItem_0 (Guid? id, int? item, bool? details = null, string accept = null, bool? pretty = null)

Get a Shop

Get detailed information about a shop item     **Required permissions:**    - **vshop.vshop.item.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShopItem_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var item = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a Shop
                VillagerShopsStockItem result = apiInstance.GetShopItem_0(id, item, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.GetShopItem_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **item** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsStockItem**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshop_0"></a>
# **GetShop_0**
> VillagerShopsShop GetShop_0 (Guid? id, bool? details = null, string accept = null, bool? pretty = null)

Get a Shop

Get detailed information about a shop     **Required permissions:**    - **vshop.vshop.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShop_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a Shop
                VillagerShopsShop result = apiInstance.GetShop_0(id, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.GetShop_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshopitems"></a>
# **ListShopItems**
> List<VillagerShopsStockItem> ListShopItems (Guid? id, bool? details = null, string accept = null, bool? pretty = null)

List Shop Items

Return a list of all shops items     **Required permissions:**    - **vshop.vshop.item.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListShopItemsExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List Shop Items
                List&lt;VillagerShopsStockItem&gt; result = apiInstance.ListShopItems(id, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.ListShopItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**List<VillagerShopsStockItem>**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshopitems_0"></a>
# **ListShopItems_0**
> List<VillagerShopsStockItem> ListShopItems_0 (Guid? id, bool? details = null, string accept = null, bool? pretty = null)

List Shop Items

Return a list of all shops items     **Required permissions:**    - **vshop.vshop.item.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListShopItems_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List Shop Items
                List&lt;VillagerShopsStockItem&gt; result = apiInstance.ListShopItems_0(id, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.ListShopItems_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**List<VillagerShopsStockItem>**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshops"></a>
# **ListShops**
> List<VillagerShopsShop> ListShops (bool? details = null, string accept = null, bool? pretty = null)

List Shops

Return a list of all shops     **Required permissions:**    - **vshop.vshop.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListShopsExample
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

            var apiInstance = new VillagerShopsApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List Shops
                List&lt;VillagerShopsShop&gt; result = apiInstance.ListShops(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.ListShops: " + e.Message );
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

[**List<VillagerShopsShop>**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listshops_0"></a>
# **ListShops_0**
> List<VillagerShopsShop> ListShops_0 (bool? details = null, string accept = null, bool? pretty = null)

List Shops

Return a list of all shops     **Required permissions:**    - **vshop.vshop.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListShops_0Example
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

            var apiInstance = new VillagerShopsApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List Shops
                List&lt;VillagerShopsShop&gt; result = apiInstance.ListShops_0(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.ListShops_0: " + e.Message );
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

[**List<VillagerShopsShop>**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshop"></a>
# **UpdateShop**
> VillagerShopsShop UpdateShop (Guid? id, VillagerShopsShop body = null, bool? details = null, string accept = null, bool? pretty = null)

Change Shop

Modifies values for this shop, but items     **Required permissions:**    - **vshop.vshop.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateShopExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var body = new VillagerShopsShop(); // VillagerShopsShop |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Change Shop
                VillagerShopsShop result = apiInstance.UpdateShop(id, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.UpdateShop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **body** | [**VillagerShopsShop**](VillagerShopsShop.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshopitem"></a>
# **UpdateShopItem**
> VillagerShopsStockItem UpdateShopItem (Guid? id, int? item, VillagerShopsStockItem body = null, bool? details = null, string accept = null, bool? pretty = null)

Change Shop Item

Modifies values for this shop item     **Required permissions:**    - **vshop.vshop.item.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateShopItemExample
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var item = 56;  // int? | 
            var body = new VillagerShopsStockItem(); // VillagerShopsStockItem |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Change Shop Item
                VillagerShopsStockItem result = apiInstance.UpdateShopItem(id, item, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.UpdateShopItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **item** | **int?**|  | 
 **body** | [**VillagerShopsStockItem**](VillagerShopsStockItem.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsStockItem**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshopitem_0"></a>
# **UpdateShopItem_0**
> VillagerShopsStockItem UpdateShopItem_0 (Guid? id, int? item, VillagerShopsStockItem body = null, bool? details = null, string accept = null, bool? pretty = null)

Change Shop Item

Modifies values for this shop item     **Required permissions:**    - **vshop.vshop.item.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateShopItem_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var item = 56;  // int? | 
            var body = new VillagerShopsStockItem(); // VillagerShopsStockItem |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Change Shop Item
                VillagerShopsStockItem result = apiInstance.UpdateShopItem_0(id, item, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.UpdateShopItem_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **item** | **int?**|  | 
 **body** | [**VillagerShopsStockItem**](VillagerShopsStockItem.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsStockItem**](VillagerShopsStockItem.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateshop_0"></a>
# **UpdateShop_0**
> VillagerShopsShop UpdateShop_0 (Guid? id, VillagerShopsShop body = null, bool? details = null, string accept = null, bool? pretty = null)

Change Shop

Modifies values for this shop, but items     **Required permissions:**    - **vshop.vshop.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateShop_0Example
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

            var apiInstance = new VillagerShopsApi();
            var id = new Guid?(); // Guid? | 
            var body = new VillagerShopsShop(); // VillagerShopsShop |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Change Shop
                VillagerShopsShop result = apiInstance.UpdateShop_0(id, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VillagerShopsApi.UpdateShop_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **body** | [**VillagerShopsShop**](VillagerShopsShop.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**VillagerShopsShop**](VillagerShopsShop.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

