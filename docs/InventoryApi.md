# IO.Swagger.Api.InventoryApi

All URIs are relative to *https://localhost/api/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddElement**](InventoryApi.md#addelement) | **POST** /megamenus/menu/{mid}/{page}/{y}/{x} | Add element
[**CloseRenderer**](InventoryApi.md#closerenderer) | **DELETE** /megamenus/render/{mid}/{viewer} | Close renderer
[**CreateMenu**](InventoryApi.md#createmenu) | **POST** /megamenus/menu | Create menu
[**CreateRenderer**](InventoryApi.md#createrenderer) | **POST** /megamenus/render/{mid} | Create menu
[**DeleteElement**](InventoryApi.md#deleteelement) | **DELETE** /megamenus/menu/{mid}/{page}/{y}/{x} | Delete menu
[**DeleteMenu**](InventoryApi.md#deletemenu) | **DELETE** /megamenus/menu/{mid} | Delete menu
[**DeletePage**](InventoryApi.md#deletepage) | **DELETE** /megamenus/menu/{mid}/{page} | Delete a page of elements
[**DeleteRenderer**](InventoryApi.md#deleterenderer) | **DELETE** /megamenus/renderer/{mid} | Delete menu
[**FindRenderer**](InventoryApi.md#findrenderer) | **GET** /megamenus/render/find/{viewer} | Get the renderer for viewer
[**GetElement**](InventoryApi.md#getelement) | **GET** /megamenus/menu/{mid}/{page}/{y}/{x} | Get menu
[**GetMenu**](InventoryApi.md#getmenu) | **GET** /megamenus/menu/{mid} | Get menu
[**GetPage**](InventoryApi.md#getpage) | **GET** /megamenus/menu/{mid}/{page} | Reads a single page of elements
[**GetRenderer**](InventoryApi.md#getrenderer) | **GET** /megamenus/render/{mid} | Get the renderer for this menu
[**ListMenus**](InventoryApi.md#listmenus) | **GET** /megamenus/menu | List menus
[**ListRenderer**](InventoryApi.md#listrenderer) | **GET** /megamenus/render | List renderer
[**OpenRenderer**](InventoryApi.md#openrenderer) | **PUT** /megamenus/render/{mid}/{viewer} | Open renderer
[**SetElement**](InventoryApi.md#setelement) | **PUT** /megamenus/menu/{mid}/{page}/{y}/{x} | Update menu
[**SetMenu**](InventoryApi.md#setmenu) | **PUT** /megamenus/menu/{mid} | Update menu


<a name="addelement"></a>
# **AddElement**
> MegaMenusElement AddElement (Guid? mid, int? page, int? y, int? x, MegaMenusElement body = null, bool? details = null, string accept = null, bool? pretty = null)

Add element

Adds an element to the menu     **Required permissions:**    - **megamenus.megamenus.menu.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddElementExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var page = 56;  // int? | 
            var y = 56;  // int? | 
            var x = 56;  // int? | 
            var body = new MegaMenusElement(); // MegaMenusElement |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Add element
                MegaMenusElement result = apiInstance.AddElement(mid, page, y, x, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.AddElement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **page** | **int?**|  | 
 **y** | **int?**|  | 
 **x** | **int?**|  | 
 **body** | [**MegaMenusElement**](MegaMenusElement.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusElement**](MegaMenusElement.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="closerenderer"></a>
# **CloseRenderer**
> MegaMenusRenderer CloseRenderer (Guid? mid, Guid? viewer, bool? details = null, string accept = null, bool? pretty = null)

Close renderer

Close the renderer for this viewer     **Required permissions:**    - **megamenus.megamenus.renderer.close**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CloseRendererExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var viewer = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Close renderer
                MegaMenusRenderer result = apiInstance.CloseRenderer(mid, viewer, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.CloseRenderer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **viewer** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusRenderer**](MegaMenusRenderer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmenu"></a>
# **CreateMenu**
> MenuMenusMenu CreateMenu (MenuMenusMenu body = null, bool? details = null, string accept = null, bool? pretty = null)

Create menu

Creates a new menu     **Required permissions:**    - **megamenus.megamenus.menu.create**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMenuExample
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

            var apiInstance = new InventoryApi();
            var body = new MenuMenusMenu(); // MenuMenusMenu |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Create menu
                MenuMenusMenu result = apiInstance.CreateMenu(body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MenuMenusMenu**](MenuMenusMenu.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MenuMenusMenu**](MenuMenusMenu.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrenderer"></a>
# **CreateRenderer**
> MegaMenusRenderer CreateRenderer (Guid? mid, MegaMenusRenderer body = null, bool? details = null, string accept = null, bool? pretty = null)

Create menu

Creates a new menu     **Required permissions:**    - **megamenus.megamenus.renderer.create**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateRendererExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var body = new MegaMenusRenderer(); // MegaMenusRenderer |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Create menu
                MegaMenusRenderer result = apiInstance.CreateRenderer(mid, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateRenderer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **body** | [**MegaMenusRenderer**](MegaMenusRenderer.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusRenderer**](MegaMenusRenderer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteelement"></a>
# **DeleteElement**
> MegaMenusElement DeleteElement (Guid? mid, int? page, int? x, int? y, bool? details = null, string accept = null, bool? pretty = null)

Delete menu

Deletes a menu element     **Required permissions:**    - **megamenus.megamenus.menu.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteElementExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var page = 56;  // int? | 
            var x = 56;  // int? | 
            var y = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Delete menu
                MegaMenusElement result = apiInstance.DeleteElement(mid, page, x, y, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteElement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **page** | **int?**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusElement**](MegaMenusElement.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemenu"></a>
# **DeleteMenu**
> MenuMenusMenu DeleteMenu (Guid? mid, bool? details = null, string accept = null, bool? pretty = null)

Delete menu

Deletes a menu     **Required permissions:**    - **megamenus.megamenus.menu.delete**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteMenuExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Delete menu
                MenuMenusMenu result = apiInstance.DeleteMenu(mid, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MenuMenusMenu**](MenuMenusMenu.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepage"></a>
# **DeletePage**
> MenuMenusMenu DeletePage (Guid? mid, int? page, bool? details = null, string accept = null, bool? pretty = null)

Delete a page of elements

     **Required permissions:**    - **megamenus.megamenus.menu.delete**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePageExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var page = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Delete a page of elements
                MenuMenusMenu result = apiInstance.DeletePage(mid, page, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DeletePage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **page** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MenuMenusMenu**](MenuMenusMenu.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterenderer"></a>
# **DeleteRenderer**
> MegaMenusRenderer DeleteRenderer (Guid? mid, bool? details = null, string accept = null, bool? pretty = null)

Delete menu

Closes this renderer for all currently active viewers     **Required permissions:**    - **megamenus.megamenus.renderer.close**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRendererExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Delete menu
                MegaMenusRenderer result = apiInstance.DeleteRenderer(mid, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteRenderer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusRenderer**](MegaMenusRenderer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findrenderer"></a>
# **FindRenderer**
> MegaMenusRenderer FindRenderer (Guid? viewer, bool? details = null, string accept = null, bool? pretty = null)

Get the renderer for viewer

Returns the renderer the viewer is currently subject to     **Required permissions:**    - **megamenus.megamenus.renderer.get**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FindRendererExample
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

            var apiInstance = new InventoryApi();
            var viewer = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get the renderer for viewer
                MegaMenusRenderer result = apiInstance.FindRenderer(viewer, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.FindRenderer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewer** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusRenderer**](MegaMenusRenderer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getelement"></a>
# **GetElement**
> MegaMenusElement GetElement (Guid? mid, int? page, int? x, int? y, bool? details = null, string accept = null, bool? pretty = null)

Get menu

Read a menu with all elements     **Required permissions:**    - **megamenus.megamenus.menu.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetElementExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var page = 56;  // int? | 
            var x = 56;  // int? | 
            var y = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get menu
                MegaMenusElement result = apiInstance.GetElement(mid, page, x, y, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetElement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **page** | **int?**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusElement**](MegaMenusElement.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmenu"></a>
# **GetMenu**
> MenuMenusMenu GetMenu (Guid? mid, bool? details = null, string accept = null, bool? pretty = null)

Get menu

Read a menu with all elements     **Required permissions:**    - **megamenus.megamenus.menu.get**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMenuExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get menu
                MenuMenusMenu result = apiInstance.GetMenu(mid, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MenuMenusMenu**](MenuMenusMenu.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpage"></a>
# **GetPage**
> List<MegaMenusElement> GetPage (Guid? mid, int? page, bool? details = null, string accept = null, bool? pretty = null)

Reads a single page of elements

     **Required permissions:**    - **megamenus.megamenus.menu.get**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPageExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var page = 56;  // int? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Reads a single page of elements
                List&lt;MegaMenusElement&gt; result = apiInstance.GetPage(mid, page, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **page** | **int?**|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**List<MegaMenusElement>**](MegaMenusElement.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrenderer"></a>
# **GetRenderer**
> MegaMenusRenderer GetRenderer (Guid? mid, bool? details = null, string accept = null, bool? pretty = null)

Get the renderer for this menu

     **Required permissions:**    - **megamenus.megamenus.renderer.get**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRendererExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get the renderer for this menu
                MegaMenusRenderer result = apiInstance.GetRenderer(mid, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetRenderer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusRenderer**](MegaMenusRenderer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmenus"></a>
# **ListMenus**
> List<MenuMenusMenu> ListMenus (bool? details = null, string accept = null, bool? pretty = null)

List menus

Returns a list of all menus     **Required permissions:**    - **megamenus.megamenus.menu.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMenusExample
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

            var apiInstance = new InventoryApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List menus
                List&lt;MenuMenusMenu&gt; result = apiInstance.ListMenus(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListMenus: " + e.Message );
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

[**List<MenuMenusMenu>**](MenuMenusMenu.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrenderer"></a>
# **ListRenderer**
> List<MegaMenusRenderer> ListRenderer (bool? details = null, string accept = null, bool? pretty = null)

List renderer

Returns a list of all renderer for menus created with WebAPI     **Required permissions:**    - **megamenus.megamenus.renderer.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListRendererExample
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

            var apiInstance = new InventoryApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List renderer
                List&lt;MegaMenusRenderer&gt; result = apiInstance.ListRenderer(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListRenderer: " + e.Message );
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

[**List<MegaMenusRenderer>**](MegaMenusRenderer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="openrenderer"></a>
# **OpenRenderer**
> MegaMenusRenderer OpenRenderer (Guid? mid, Guid? viewer, bool? details = null, string accept = null, bool? pretty = null)

Open renderer

Opens the renderer to viewer, effectively opening the menu     **Required permissions:**    - **megamenus.megamenus.renderer.open**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenRendererExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var viewer = new Guid?(); // Guid? | 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Open renderer
                MegaMenusRenderer result = apiInstance.OpenRenderer(mid, viewer, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.OpenRenderer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **viewer** | [**Guid?**](Guid?.md)|  | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusRenderer**](MegaMenusRenderer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setelement"></a>
# **SetElement**
> MegaMenusElement SetElement (Guid? mid, int? page, int? x, int? y, MegaMenusElement body = null, bool? details = null, string accept = null, bool? pretty = null)

Update menu

Update a menu element     **Required permissions:**    - **megamenus.megamenus.menu.edit**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetElementExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var page = 56;  // int? | 
            var x = 56;  // int? | 
            var y = 56;  // int? | 
            var body = new MegaMenusElement(); // MegaMenusElement |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Update menu
                MegaMenusElement result = apiInstance.SetElement(mid, page, x, y, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.SetElement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **page** | **int?**|  | 
 **x** | **int?**|  | 
 **y** | **int?**|  | 
 **body** | [**MegaMenusElement**](MegaMenusElement.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MegaMenusElement**](MegaMenusElement.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmenu"></a>
# **SetMenu**
> MenuMenusMenu SetMenu (Guid? mid, MenuMenusMenu body = null, bool? details = null, string accept = null, bool? pretty = null)

Update menu

This will only update the title, elements have to be addressed through the respective endpoints     **Required permissions:**    - **megamenus.megamenus.menu.update**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetMenuExample
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

            var apiInstance = new InventoryApi();
            var mid = new Guid?(); // Guid? | 
            var body = new MenuMenusMenu(); // MenuMenusMenu |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Update menu
                MenuMenusMenu result = apiInstance.SetMenu(mid, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.SetMenu: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mid** | [**Guid?**](Guid?.md)|  | 
 **body** | [**MenuMenusMenu**](MenuMenusMenu.md)|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**MenuMenusMenu**](MenuMenusMenu.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

