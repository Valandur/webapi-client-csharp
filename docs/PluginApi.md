# IO.Swagger.Api.PluginApi

All URIs are relative to *https://localhost/api/v5*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePluginConfig**](PluginApi.md#changepluginconfig) | **POST** /plugin/{plugin}/config | Change plugin configs
[**GetPlugin**](PluginApi.md#getplugin) | **GET** /plugin/{plugin} | Get a plugin
[**GetPluginConfig**](PluginApi.md#getpluginconfig) | **GET** /plugin/{plugin}/config | Get plugin configs
[**ListPlugins**](PluginApi.md#listplugins) | **GET** /plugin | List plugins
[**TogglePlugin**](PluginApi.md#toggleplugin) | **PUT** /plugin/{plugin} | Toggle a plugin


<a name="changepluginconfig"></a>
# **ChangePluginConfig**
> Dictionary<string, Object> ChangePluginConfig (string plugin, Object body = null, bool? details = null, string accept = null, bool? pretty = null)

Change plugin configs

Allows changing the config files of plugin. Send a map from config filename to file contents. **This does not reload the plugin**, you can do that with `sponge plugins reload`, but not all plugins implement the reload event.     **Required permissions:**    - **plugin.config.modify**   - **plugin.config.modify.[plugin]**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangePluginConfigExample
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

            var apiInstance = new PluginApi();
            var plugin = plugin_example;  // string | The id of the plugin
            var body = ;  // Object |  (optional) 
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Change plugin configs
                Dictionary&lt;string, Object&gt; result = apiInstance.ChangePluginConfig(plugin, body, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginApi.ChangePluginConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plugin** | **string**| The id of the plugin | 
 **body** | **Object**|  | [optional] 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

**Dictionary<string, Object>**

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplugin"></a>
# **GetPlugin**
> PluginContainer GetPlugin (string plugin, bool? details = null, string accept = null, bool? pretty = null)

Get a plugin

Gets detailed information about a plugin.     **Required permissions:**    - **plugin.one**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPluginExample
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

            var apiInstance = new PluginApi();
            var plugin = plugin_example;  // string | The id of the plugin
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get a plugin
                PluginContainer result = apiInstance.GetPlugin(plugin, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginApi.GetPlugin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plugin** | **string**| The id of the plugin | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**PluginContainer**](PluginContainer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpluginconfig"></a>
# **GetPluginConfig**
> Dictionary<string, Object> GetPluginConfig (string plugin, bool? details = null, string accept = null, bool? pretty = null)

Get plugin configs

Gets a map containing the plugin config file names as keys, and their config file contents as their values.     **Required permissions:**    - **plugin.config.get**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPluginConfigExample
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

            var apiInstance = new PluginApi();
            var plugin = plugin_example;  // string | The id of the plugin
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Get plugin configs
                Dictionary&lt;string, Object&gt; result = apiInstance.GetPluginConfig(plugin, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginApi.GetPluginConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plugin** | **string**| The id of the plugin | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

**Dictionary<string, Object>**

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listplugins"></a>
# **ListPlugins**
> List<PluginContainer> ListPlugins (bool? details = null, string accept = null, bool? pretty = null)

List plugins

Get a list of all the plugins running on the server.     **Required permissions:**    - **plugin.list**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPluginsExample
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

            var apiInstance = new PluginApi();
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // List plugins
                List&lt;PluginContainer&gt; result = apiInstance.ListPlugins(details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginApi.ListPlugins: " + e.Message );
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

[**List<PluginContainer>**](PluginContainer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toggleplugin"></a>
# **TogglePlugin**
> PluginContainer TogglePlugin (string plugin, bool? details = null, string accept = null, bool? pretty = null)

Toggle a plugin

Allows enabling/disabling a plugin/mod. Requires a server restart.     **Required permissions:**    - **plugin.toggle**   

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TogglePluginExample
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

            var apiInstance = new PluginApi();
            var plugin = plugin_example;  // string | The id of the plugin
            var details = true;  // bool? | Add to include additional details, omit or false otherwise (optional) 
            var accept = accept_example;  // string | Override the 'Accept' request header (useful for debugging your requests) (optional) 
            var pretty = true;  // bool? | Add to make the Web-API pretty print the response (useful for debugging your requests) (optional) 

            try
            {
                // Toggle a plugin
                PluginContainer result = apiInstance.TogglePlugin(plugin, details, accept, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PluginApi.TogglePlugin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plugin** | **string**| The id of the plugin | 
 **details** | **bool?**| Add to include additional details, omit or false otherwise | [optional] 
 **accept** | **string**| Override the &#39;Accept&#39; request header (useful for debugging your requests) | [optional] 
 **pretty** | **bool?**| Add to make the Web-API pretty print the response (useful for debugging your requests) | [optional] 

### Return type

[**PluginContainer**](PluginContainer.md)

### Authorization

[ApiKeyHeader](../README.md#ApiKeyHeader), [ApiKeyQuery](../README.md#ApiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

